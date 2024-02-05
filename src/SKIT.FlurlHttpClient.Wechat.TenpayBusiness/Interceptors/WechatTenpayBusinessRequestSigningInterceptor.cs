using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Interceptors
{
    using SKIT.FlurlHttpClient.Internal;
    using SKIT.FlurlHttpClient.Primitives;

    internal class WechatTenpayBusinessRequestSigningInterceptor : HttpInterceptor
    {
        private const string HTTP_HEADER_PLATFORM_AUTHORIZATION = HttpHeaders.Authorization;
        private const string HTTP_HEADER_ENTERPRISE_AUTHORIZATION = "Enterprise-Authorization";

        private readonly string _signAlg;
        private readonly string _platformId;
        private readonly string _platformCertSn;
        private readonly string _platformCertPk;
        private readonly string? _enterpriseId;
        private readonly string? _enterpriseCertSn;
        private readonly string? _enterpriseCertPk;

        public WechatTenpayBusinessRequestSigningInterceptor(string signAlg, string platformId, string platformCertSn, string platformCertPk, string? enterpriseId, string? enterpriseCertSn, string? enterpriseCertPk)
        {
            _signAlg = signAlg;
            _platformId = platformId;
            _platformCertSn = platformCertSn;
            _platformCertPk = platformCertPk;
            _enterpriseId = enterpriseId;
            _enterpriseCertSn = enterpriseCertSn;
            _enterpriseCertPk = enterpriseCertPk;
        }

        public override async Task BeforeCallAsync(HttpInterceptorContext context, CancellationToken cancellationToken = default)
        {
            if (context is null) throw new ArgumentNullException(nameof(context));
            if (context.FlurlCall.Completed) throw new WechatTenpayBusinessException("Failed to sign request. This interceptor must be called before request completed.");

            string method = context.FlurlCall.HttpRequestMessage.Method.ToString().ToUpper();
            string url = context.FlurlCall.HttpRequestMessage.RequestUri?.PathAndQuery ?? string.Empty;
            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string body = string.Empty;

            if (context.FlurlCall.HttpRequestMessage.Content is MultipartFormDataContent formdataContent)
            {
                // NOTICE: multipart/form-data 文件上传请求的待签名参数需特殊处理
                var httpContent = formdataContent.SingleOrDefault(e => Constants.FormDataFields.FORMDATA_META.Equals(e.Headers.ContentDisposition?.Name?.Trim('\"')));
                if (httpContent is not null)
                {
                    body = await _AsyncEx.RunTaskWithCancellationTokenAsync(httpContent.ReadAsStringAsync(), cancellationToken).ConfigureAwait(false);
                }
            }
            else
            {
                body = context.FlurlCall.RequestBody ?? string.Empty;
            }

            string plainText = $"{method}\n{url}\n{timestamp}\n{nonce}\n{body}\n";
            string signText;

            bool softSignRequired = _enterpriseId is not null && _enterpriseCertSn is not null && _enterpriseCertPk is not null;
            string? softSignText = null;

            switch (_signAlg)
            {
                case Constants.SignAlgorithms.SHA256_WITH_RSA:
                    {
                        try
                        {
                            signText = Utilities.RSAUtility.Sign(_platformCertPk, plainText).Value!;

                            if (softSignRequired)
                            {
                                byte[] keyBytes = EncodedString.FromBase64String(_enterpriseCertPk!);
                                byte[] msgBytes = EncodedString.FromBase64String(signText);
                                softSignText = EncodedString.ToBase64String(Utilities.RSAUtility.Sign(keyBytes, msgBytes)).Value!;
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new WechatTenpayBusinessException("Failed to sign request. Please see the inner exception for more details.", ex);
                        }
                    }
                    break;

                default:
                    throw new WechatTenpayBusinessException($"Failed to sign request. Unsupported signing algorithm: \"{_signAlg}\".");
            }

            context.FlurlCall.Request.WithHeader(HTTP_HEADER_PLATFORM_AUTHORIZATION, $"platform_id=\"{_platformId}\",platform_serial_number=\"{_platformCertSn}\",nonce=\"{nonce}\",timestamp=\"{timestamp}\",signature=\"{signText}\",signature_algorithm=\"{_signAlg}\"");

            if (softSignRequired)
            {
                context.FlurlCall.Request.WithHeader(HTTP_HEADER_ENTERPRISE_AUTHORIZATION, $"ent_id=\"{_enterpriseId}\",enterprise_serial_number=\"{_enterpriseCertSn}\",signature=\"{softSignText}\",signature_algorithm=\"{_signAlg}\"");
            }
        }
    }
}
