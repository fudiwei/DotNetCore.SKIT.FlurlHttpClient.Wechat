using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api.Interceptors
{
    using SKIT.FlurlHttpClient.Internal;
    using SKIT.FlurlHttpClient.Wechat.Api.Constants;

    internal class WechatApiSecurityApiInterceptor : HttpInterceptor
    {
        /**
         * REF:
         *   https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/getting_started/api_signature.html
         *   https://developers.weixin.qq.com/community/develop/article/doc/00028ca675c708b23f100b8e161013
         *   https://developers.weixin.qq.com/community/develop/article/doc/000e68b8038ed8796f00f6c2f68c13
         */
        private static readonly ISet<string> SIGN_REQUIRED_URLS = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "/cgi-bin/clear_quota",
            "/cgi-bin/openapi/quota/get",
            "/cgi-bin/openapi/rid/get",
            "/wxa/getpluginopenpid",
            "/wxa/business/checkencryptedmsg",
            "/wxa/business/getuserencryptkey",
            "/wxa/business/getuserphonenumber",
            "/wxa/getwxacode",
            "/wxa/getwxacodeunlimit",
            "/cgi-bin/wxaapp/createwxaqrcode",
            "/cgi-bin/message/custom/send",
            "/cgi-bin/message/wxopen/updatablemsg/send",
            "/wxaapi/newtmpl/deltemplate",
            "/cgi-bin/message/subscribe/send",
            "/wxaapi/newtmpl/addtemplate",
            "/wxa/msg_sec_check",
            "/wxa/media_check_async",
            "/wxa/getuserriskrank",
            "/datacube/getweanalysisappidweeklyretaininfo",
            "/datacube/getweanalysisappidmonthlyretaininfo",
            "/datacube/getweanalysisappiddailyretaininfo",
            "/datacube/getweanalysisappidmonthlyvisittrend",
            "/datacube/getweanalysisappiddailyvisittrend",
            "/datacube/getweanalysisappidweeklyvisittrend",
            "/datacube/getweanalysisappiddailysummarytrend",
            "/datacube/getweanalysisappidvisitpage",
            "/datacube/getweanalysisappiduserportrait",
            "/wxa/business/performance/boot",
            "/datacube/getweanalysisappidvisitdistribution",
            "/wxa/getwxadevinfo",
            "/wxaapi/log/get_performance",
            "/wxaapi/log/jserr_detail",
            "/wxaapi/log/jserr_list",
            "/wxa/devplugin",
            "/wxa/plugin",
            "/cgi-bin/express/business/account/getall",
            "/cgi-bin/express/business/delivery/getall",
            "/cgi-bin/express/business/printer/getall",
            "/wxa/servicemarket",
            "/cgi-bin/soter/verify_signature",
            "/cgi-bin/express/intracity/apply",
            "/cgi-bin/express/intracity/createstore",
            "/cgi-bin/express/intracity/querystore",
            "/cgi-bin/express/intracity/updatestore",
            "/cgi-bin/express/intracity/storecharge",
            "/cgi-bin/express/intracity/storerefund",
            "/cgi-bin/express/intracity/queryflow",
            "/cgi-bin/express/intracity/balancequery",
            "/cgi-bin/express/intracity/preaddorder",
            "/cgi-bin/express/intracity/addorder",
            "/cgi-bin/express/intracity/queryorder",
            "/cgi-bin/express/intracity/cancelorder",
            "/cgi-bin/express/intracity/setpaymode",
            "/cgi-bin/express/intracity/getpaymode",
            "/cgi-bin/express/intracity/getcity",
            "/cgi-bin/express/intracity/mocknotify"
        };

        private readonly string _baseUrl;
        private readonly string _appId;
        private readonly string _symmetricAlg;
        private readonly string _symmetricNum;
        private readonly string _symmetricKey;
        private readonly string _asymmetricAlg;
        private readonly string _asymmetricNum;
        private readonly string _asymmetricPrivateKey;
        private readonly Func<string, bool>? _customRequestPathMatcher;

        public WechatApiSecurityApiInterceptor(string baseUrl, string appId, string symmetricAlg, string symmetricNum, string symmetricKey, string asymmetricAlg, string asymmetricNum, string asymmetricPrivateKey, Func<string, bool>? customRequestPathMatcher)
        {
            _baseUrl = baseUrl;
            _appId = appId;
            _symmetricAlg = symmetricAlg;
            _symmetricNum = symmetricNum;
            _symmetricKey = symmetricKey;
            _asymmetricAlg = asymmetricAlg;
            _asymmetricNum = asymmetricNum;
            _asymmetricPrivateKey = asymmetricPrivateKey;
            _customRequestPathMatcher = customRequestPathMatcher;
        }

        public override async Task BeforeCallAsync(HttpInterceptorContext context, CancellationToken cancellationToken = default)
        {
            if (context is null) throw new ArgumentNullException(nameof(context));
            if (context.FlurlCall.Completed) throw new WechatApiException("Failed to encrypt and sign request. This interceptor must be called before request completed.");

            if (context.FlurlCall.HttpRequestMessage.Method != HttpMethod.Post)
                return;
            if (context.FlurlCall.HttpRequestMessage.RequestUri is null)
                return;
            if (!IsRequestUrlRequireEncryption(context.FlurlCall.HttpRequestMessage.RequestUri))
                return;

            string urlpath = GetRequestUrl(context.FlurlCall.HttpRequestMessage.RequestUri);
            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string postData = "{}";
            string postDataEncrypted;
            if (context.FlurlCall.HttpRequestMessage?.Content is not null)
            {
                if (context.FlurlCall.HttpRequestMessage.Content is MultipartFormDataContent)
                    return;

                HttpContent httpContent = context.FlurlCall.HttpRequestMessage.Content;
                postData = await
#if NET5_0_OR_GREATER
                    httpContent.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
#else
                    _AsyncEx.RunTaskWithCancellationTokenAsync(httpContent.ReadAsStringAsync(), cancellationToken).ConfigureAwait(false);
#endif
                if (string.IsNullOrEmpty(postData))
                    postData = "{}";
            }

            // 对称加密
            if (string.IsNullOrEmpty(_symmetricKey))
            {
                throw new WechatApiException("Failed to encrypt request, because the AES/SM4 key is not set.");
            }
            else
            {
                string nonce = GenerateSymmetricEncryptionNonce(12);
                string associatedData = GenerateSymmetricEncryptionAssociatedData(urlpath, _appId, timestamp);
                string plainData;
                try
                {
                    JsonObject jsonObj = JsonObject.Parse(postData)!.AsObject();
                    jsonObj["_n"] = GenerateSymmetricEncryptionNonce(16);
                    jsonObj["_appid"] = _appId;
                    jsonObj["_timestamp"] = timestamp;

                    NameValueCollection queryParams = HttpUtility.ParseQueryString(context.FlurlCall.HttpRequestMessage!.RequestUri.Query);
                    foreach (string? key in queryParams.AllKeys)
                    {
                        if (key is null) continue;
                        if (key == "access_token") continue;
                        jsonObj[key] = queryParams[key];
                    }

                    plainData = jsonObj.ToJsonString(SystemTextJsonSerializer.GetDefaultSerializerOptions());
                }
                catch (Exception ex)
                {
                    throw new WechatApiException("Failed to encrypt request. Please see the inner exception for more details.", ex);
                }

                string sData, sIV, sAuthTag;
                switch (_symmetricAlg)
                {
                    case SecurityApiSymmetricAlgorithms.AES:
                        {
                            try
                            {
                                const int TAG_LENGTH_BYTE = 16;
                                byte[] cipherBytes = Utilities.AESUtility.EncryptWithGCM(
                                    keyBytes: Convert.FromBase64String(_symmetricKey),
                                    nonceBytes: Convert.FromBase64String(nonce),
                                    associatedDataBytes: Encoding.UTF8.GetBytes(associatedData),
                                    plainBytes: Encoding.UTF8.GetBytes(plainData)
                                )!;
                                byte[] encdataBytes = new byte[cipherBytes.Length - TAG_LENGTH_BYTE];
                                byte[] authtagBytes = new byte[TAG_LENGTH_BYTE];
                                Buffer.BlockCopy(cipherBytes, 0, encdataBytes, 0, encdataBytes.Length);
                                Buffer.BlockCopy(cipherBytes, encdataBytes.Length, authtagBytes, 0, authtagBytes.Length);

                                sIV = nonce;
                                sData = Convert.ToBase64String(encdataBytes);
                                sAuthTag = Convert.ToBase64String(authtagBytes);
                            }
                            catch (Exception ex)
                            {
                                throw new WechatApiException("Failed to encrypt request. Please see the inner exception for more details.", ex);
                            }
                        }
                        break;

                    case SecurityApiSymmetricAlgorithms.SM4:
                        {
                            try
                            {
                                const int TAG_LENGTH_BYTE = 16;
                                byte[] cipherBytes = Utilities.SM4Utility.EncryptWithGCM(
                                    keyBytes: Convert.FromBase64String(_symmetricKey),
                                    nonceBytes: Convert.FromBase64String(nonce),
                                    associatedDataBytes: Encoding.UTF8.GetBytes(associatedData),
                                    plainBytes: Encoding.UTF8.GetBytes(plainData)
                                )!;
                                byte[] encdataBytes = new byte[cipherBytes.Length - TAG_LENGTH_BYTE];
                                byte[] authtagBytes = new byte[TAG_LENGTH_BYTE];
                                Buffer.BlockCopy(cipherBytes, 0, encdataBytes, 0, encdataBytes.Length);
                                Buffer.BlockCopy(cipherBytes, encdataBytes.Length, authtagBytes, 0, authtagBytes.Length);

                                sIV = nonce;
                                sData = Convert.ToBase64String(encdataBytes);
                                sAuthTag = Convert.ToBase64String(authtagBytes);
                            }
                            catch (Exception ex)
                            {
                                throw new WechatApiException("Failed to encrypt request. Please see the inner exception for more details.", ex);
                            }
                        }
                        break;

                    default:
                        throw new WechatApiException($"Failed to encrypt request. Unsupported encryption algorithm: \"{_symmetricAlg}\".");
                }

                IDictionary<string, string> temp = new Dictionary<string, string>(capacity: 4)
                {
                    { "iv", sIV },
                    { "data", sData },
                    { "authtag", sAuthTag }
                };
                postDataEncrypted = JsonSerializer.Serialize(temp, SystemTextJsonSerializer.GetDefaultSerializerOptions());
                context.FlurlCall.HttpRequestMessage!.Content?.Dispose();
                context.FlurlCall.HttpRequestMessage!.Content = new StringContent(postDataEncrypted, Encoding.UTF8, MimeTypes.Json);
            }

            // 非对称签名
            if (string.IsNullOrEmpty(_asymmetricPrivateKey))
            {
                throw new WechatApiException("Failed to sign request, because the RSA/SM2 private key is not set.");
            }
            else
            {
                string signData = $"{urlpath}\n{_appId}\n{timestamp}\n{postDataEncrypted}";
                string sign;

                switch (_asymmetricAlg)
                {
                    case SecurityApiAsymmetricAlgorithms.RSA:
                        {
                            try
                            {
                                sign = Utilities.RSAUtility.SignWithSHA256PSS(_asymmetricPrivateKey, signData).Value!;
                            }
                            catch (Exception ex)
                            {
                                throw new WechatApiException("Failed to sign request. Please see the inner exception for more details.", ex);
                            }
                        }
                        break;

                    case SecurityApiAsymmetricAlgorithms.SM2:
                        {
                            try
                            {
                                sign = Utilities.SM2Utility.SignWithSM3(_asymmetricPrivateKey, _asymmetricNum, signData).Value!;
                            }
                            catch (Exception ex)
                            {
                                throw new WechatApiException("Failed to sign request. Please see the inner exception for more details.", ex);
                            }
                        }
                        break;

                    default:
                        throw new WechatApiException($"Failed to sign request. Unsupported signing algorithm: \"{_asymmetricAlg}\".");
                }

                context.FlurlCall.Request.WithHeader("Wechatmp-Appid", _appId);
                context.FlurlCall.Request.WithHeader("Wechatmp-TimeStamp", timestamp);
                context.FlurlCall.Request.WithHeader("Wechatmp-Signature", sign);
            }
        }

        public override async Task AfterCallAsync(HttpInterceptorContext context, CancellationToken cancellationToken = default)
        {
            if (context is null) throw new ArgumentNullException(nameof(context));
            if (!context.FlurlCall.Completed) throw new WechatApiException("Failed to decrypt and verify response. This interceptor must be called after request completed.");

            if (context.FlurlCall.HttpRequestMessage.Method != HttpMethod.Post)
                return;
            if (context.FlurlCall.HttpRequestMessage.RequestUri is null)
                return;
            if (!IsRequestUrlRequireEncryption(context.FlurlCall.HttpRequestMessage.RequestUri))
                return;
            if (context.FlurlCall.HttpResponseMessage is null)
                return;

            string urlpath = GetRequestUrl(context.FlurlCall.HttpRequestMessage.RequestUri);
            byte[] respBytes = Array.Empty<byte>();
            if (context.FlurlCall.HttpResponseMessage.Content is not null)
            {
                HttpContent httpContent = context.FlurlCall.HttpResponseMessage.Content;
                respBytes = await
#if NET5_0_OR_GREATER
                    httpContent.ReadAsByteArrayAsync(cancellationToken).ConfigureAwait(false);
#else
                    _AsyncEx.RunTaskWithCancellationTokenAsync(httpContent.ReadAsByteArrayAsync(), cancellationToken).ConfigureAwait(false);
#endif
            }

            // 对称解密
            if (string.IsNullOrEmpty(_symmetricKey))
            {
                throw new WechatApiException("Failed to decrypt response, because the AES/SM4 key is not set.");
            }
            else if (_StringSyntaxAssert.MaybeJson(respBytes))
            {
                bool requireDecrypt = false;
                string? sData = null, sIV = null, sAuthTag = null;

                try
                {
                    JsonObject jsonObj = JsonObject.Parse(respBytes)!.AsObject();
                    requireDecrypt = context.FlurlResponse!.Headers.Contains("Wechatmp-Signature")
                        && jsonObj.ContainsKey("data")
                        && jsonObj.ContainsKey("iv")
                        && jsonObj.ContainsKey("authtag");

                    if (requireDecrypt)
                    {
                        sData = jsonObj["data"]!.GetValue<string>();
                        sIV = jsonObj["iv"]!.GetValue<string>();
                        sAuthTag = jsonObj["authtag"]!.GetValue<string>();
                    }
                }
                catch (Exception ex)
                {
                    throw new WechatApiException("Failed to decrypt response. Please see the inner exception for more details.", ex);
                }

                if (requireDecrypt)
                {
                    byte[] respBytesDecrypted;
                    string appId = context.FlurlResponse!.Headers.GetAll("Wechatmp-Appid")?.FirstOrDefault() ?? string.Empty;
                    string timestamp = context.FlurlResponse!.Headers.GetAll("Wechatmp-TimeStamp")?.FirstOrDefault() ?? string.Empty;
                    string associatedData = GenerateSymmetricEncryptionAssociatedData(urlpath, appId, timestamp);

                    switch (_symmetricAlg)
                    {
                        case SecurityApiSymmetricAlgorithms.AES:
                            {
                                try
                                {
                                    byte[] encdataBytes = Convert.FromBase64String(sData!);
                                    byte[] authtagBytes = Convert.FromBase64String(sAuthTag!);
                                    byte[] cipherBytes = new byte[encdataBytes.Length + authtagBytes.Length];
                                    Buffer.BlockCopy(encdataBytes, 0, cipherBytes, 0, encdataBytes.Length);
                                    Buffer.BlockCopy(authtagBytes, 0, cipherBytes, encdataBytes.Length, authtagBytes.Length);

                                    respBytesDecrypted = Utilities.AESUtility.DecryptWithGCM(
                                        keyBytes: Convert.FromBase64String(_symmetricKey),
                                        nonceBytes: Convert.FromBase64String(sIV!),
                                        associatedDataBytes: Encoding.UTF8.GetBytes(associatedData),
                                        cipherBytes: cipherBytes
                                    )!;
                                }
                                catch (Exception ex)
                                {
                                    throw new WechatApiException("Failed to decrypt response. Please see the inner exception for more details.", ex);
                                }
                            }
                            break;

                        case SecurityApiSymmetricAlgorithms.SM4:
                            {
                                try
                                {
                                    byte[] encdataBytes = Convert.FromBase64String(sData!);
                                    byte[] authtagBytes = Convert.FromBase64String(sAuthTag!);
                                    byte[] cipherBytes = new byte[encdataBytes.Length + authtagBytes.Length];
                                    Buffer.BlockCopy(encdataBytes, 0, cipherBytes, 0, encdataBytes.Length);
                                    Buffer.BlockCopy(authtagBytes, 0, cipherBytes, encdataBytes.Length, authtagBytes.Length);

                                    respBytesDecrypted = Utilities.SM4Utility.DecryptWithGCM(
                                        keyBytes: Convert.FromBase64String(_symmetricKey),
                                        nonceBytes: Convert.FromBase64String(sIV!),
                                        associatedDataBytes: Encoding.UTF8.GetBytes(associatedData),
                                        cipherBytes: cipherBytes
                                    )!;
                                }
                                catch (Exception ex)
                                {
                                    throw new WechatApiException("Failed to decrypt response. Please see the inner exception for more details.", ex);
                                }
                            }
                            break;

                        default:
                            throw new WechatApiException($"Failed to decrypt response. Unsupported encryption algorithm: \"{_symmetricAlg}\".");
                    }

                    context.FlurlCall.HttpResponseMessage!.Content?.Dispose();
                    context.FlurlCall.HttpResponseMessage!.Content = new ByteArrayContent(respBytesDecrypted);
                }
            }
        }

        private string GenerateSymmetricEncryptionNonce(int byteLength)
        {
            byte[] bytes = new byte[byteLength];
            new Random().NextBytes(bytes);
            return Convert.ToBase64String(bytes);
        }

        private string GenerateSymmetricEncryptionAssociatedData(string urlpath, string appId, string timestamp)
        {
            return $"{urlpath}|{appId}|{timestamp}|{_symmetricNum}";
        }

        private string GetRequestUrl(Uri uri)
        {
            return uri.AbsoluteUri.Substring(0, uri.AbsoluteUri.Length - uri.Query.Length);
        }

        private bool IsRequestUrlRequireEncryption(Uri uri)
        {
            string absoluteUrl = GetRequestUrl(uri);
            if (!absoluteUrl.StartsWith(_baseUrl))
                return false;

            string relativeUrl = absoluteUrl.Substring(_baseUrl.TrimEnd('/').Length);
            if (!SIGN_REQUIRED_URLS.Contains(relativeUrl))
            { 
                if (_customRequestPathMatcher is not null)
                    return _customRequestPathMatcher(relativeUrl);
            }

            return true;
        }
    }
}
