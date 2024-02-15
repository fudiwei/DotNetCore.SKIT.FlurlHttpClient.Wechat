using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Interceptors
{
    using SKIT.FlurlHttpClient.Internal;
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Constants;

    internal class WechatTenpayRequestSigningInterceptor : HttpInterceptor
    {
        private readonly string _scheme;
        private readonly string _mchId;
        private readonly string _mchCertSn;
        private readonly string _mchCertPk;

        public WechatTenpayRequestSigningInterceptor(string scheme, string mchId, string mchCertSn, string mchCertPk)
        {
            _scheme = scheme;
            _mchId = mchId;
            _mchCertSn = mchCertSn;
            _mchCertPk = mchCertPk;
        }

        public override async Task BeforeCallAsync(HttpInterceptorContext context, CancellationToken cancellationToken = default)
        {
            if (context is null) throw new ArgumentNullException(nameof(context));
            if (context.FlurlCall.Completed) throw new WechatTenpayException("Failed to sign request. This interceptor must be called before request completed.");

            string method = context.FlurlCall.HttpRequestMessage.Method.ToString().ToUpper();
            string url = context.FlurlCall.HttpRequestMessage.RequestUri?.PathAndQuery ?? string.Empty;
            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string body = string.Empty;

            if (context.FlurlCall.HttpRequestMessage?.Content is not null)
            {
                if (context.FlurlCall.HttpRequestMessage.Content is MultipartFormDataContent multipartFormData)
                {
                    HttpContent httpContent = multipartFormData.SingleOrDefault(e => FormDataFields.FORMDATA_META.Equals(e.Headers.ContentDisposition?.Name?.Trim('\"')));
                    if (httpContent is not null)
                    {
                        body = await _AsyncEx.RunTaskWithCancellationTokenAsync(httpContent.ReadAsStringAsync(), cancellationToken).ConfigureAwait(false);
                    }
                }
                else if (method != "GET")
                {
                    HttpContent httpContent = context.FlurlCall.HttpRequestMessage.Content;
                    body = await _AsyncEx.RunTaskWithCancellationTokenAsync(httpContent.ReadAsStringAsync(), cancellationToken).ConfigureAwait(false);
                }
            }

            string signData = $"{method}\n{url}\n{timestamp}\n{nonce}\n{body}\n";
            string sign;

            switch (_scheme)
            {
                case SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256:
                    {
                        try
                        {
                            sign = Utilities.RSAUtility.Sign(_mchCertPk, signData).Value!;
                        }
                        catch (Exception ex)
                        {
                            throw new WechatTenpayException("Failed to sign request. Please see the inner exception for more details.", ex);
                        }
                    }
                    break;

                case SignSchemes.WECHATPAY2_SM2_WITH_SM3:
                    {
                        try
                        {
                            sign = Utilities.SM2Utility.SignWithSM3(_mchCertPk, signData).Value!;
                        }
                        catch (Exception ex)
                        {
                            throw new WechatTenpayException("Failed to sign request. Please see the inner exception for more details.", ex);
                        }
                    }
                    break;

                default:
                    throw new WechatTenpayException($"Failed to sign request. Unsupported signing scheme: \"{_scheme}\".");
            }

            context.FlurlCall.Request.WithHeader(HttpHeaders.Authorization, $"{_scheme} mchid=\"{_mchId}\",nonce_str=\"{nonce}\",signature=\"{sign}\",timestamp=\"{timestamp}\",serial_no=\"{_mchCertSn}\"");
        }
    }
}
