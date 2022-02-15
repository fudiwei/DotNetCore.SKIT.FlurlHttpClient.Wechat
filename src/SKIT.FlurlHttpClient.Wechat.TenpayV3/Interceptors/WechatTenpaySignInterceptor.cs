﻿using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Interceptors
{
    internal class WechatTenpaySignInterceptor : FlurlHttpCallInterceptor
    {
        private readonly string _scheme;
        private readonly string _mchId;
        private readonly string _mchCertSn;
        private readonly string _mchCertPk;

        public WechatTenpaySignInterceptor(string scheme, string mchId, string mchCertSn, string mchCertPk)
        {
            _scheme = scheme;
            _mchId = mchId;
            _mchCertSn = mchCertSn;
            _mchCertPk = mchCertPk;
        }

        public override async Task BeforeCallAsync(FlurlCall flurlCall)
        {
            if (flurlCall == null) throw new ArgumentNullException(nameof(flurlCall));

            string method = flurlCall.HttpRequestMessage.Method.ToString().ToUpper();
            string url = flurlCall.HttpRequestMessage.RequestUri?.PathAndQuery ?? string.Empty;
            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string body = string.Empty;

            if (flurlCall.HttpRequestMessage.Content is MultipartFormDataContent formdataContent)
            {
                // NOTICE: multipart/form-data 文件上传请求的待签名参数需特殊处理
                var httpContent = formdataContent.SingleOrDefault(e => Constants.FormDataFields.FORMDATA_META.Equals(e.Headers.ContentDisposition?.Name?.Trim('\"')));
                if (httpContent != null)
                {
                    body = await httpContent.ReadAsStringAsync().ConfigureAwait(false);
                }
            }
            else
            {
                body = flurlCall.RequestBody ?? string.Empty;
            }

            string plainText = $"{method}\n{url}\n{timestamp}\n{nonce}\n{body}\n";
            string signText;

            switch (_scheme)
            {
                case Constants.SignAlgorithms.WECHATPAY2_SHA256_RSA2048:
                    {
                        try
                        {
                            signText = Utilities.RSAUtility.SignWithSHA256(_mchCertPk, plainText);
                        }
                        catch (Exception ex)
                        {
                            throw new Exceptions.WechatTenpayRequestSignatureException("Generate signature of request failed. Please see the `InnerException` for more details.", ex);
                        }
                    }
                    break;

                default:
                    throw new Exceptions.WechatTenpayRequestSignatureException("Unsupported authorization scheme.");
            }

            string auth = $"mchid=\"{_mchId}\",nonce_str=\"{nonce}\",signature=\"{signText}\",timestamp=\"{timestamp}\",serial_no=\"{_mchCertSn}\"";
            flurlCall.Request.Headers.Remove("Authorization");
            flurlCall.Request.WithHeader("Authorization", $"{_scheme} {auth}");
        }
    }
}
