using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Interceptors
{
    using SKIT.FlurlHttpClient.Constants;

    internal class WechatTenpayBusinessRequestSignatureInterceptor : FlurlHttpCallInterceptor
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

        public WechatTenpayBusinessRequestSignatureInterceptor(string signAlg, string platformId, string platformCertSn, string platformCertPk, string? enterpriseId, string? enterpriseCertSn, string? enterpriseCertPk)
        {
            _signAlg = signAlg;
            _platformId = platformId;
            _platformCertSn = platformCertSn;
            _platformCertPk = platformCertPk;
            _enterpriseId = enterpriseId;
            _enterpriseCertSn = enterpriseCertSn;
            _enterpriseCertPk = enterpriseCertPk;
        }

        public override async Task BeforeCallAsync(FlurlCall flurlCall)
        {
            if (flurlCall == null) throw new ArgumentNullException(nameof(flurlCall));
            if (flurlCall.Completed) throw new Exceptions.WechatTenpayBusinessRequestSignatureException("This interceptor must be called before request completed.");

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
                    body = await httpContent.ReadAsStringAsync();
                }
            }
            else
            {
                body = flurlCall.RequestBody ?? string.Empty;
            }

            string plainText = $"{method}\n{url}\n{timestamp}\n{nonce}\n{body}\n";
            string signText;

            bool softSignRequired = _enterpriseId != null && _enterpriseCertSn != null && _enterpriseCertPk != null;
            string? softSignText = null;

            switch (_signAlg)
            {
                case Constants.SignAlgorithms.SHA245_WITH_RSA:
                    {
                        try
                        {
                            signText = Utilities.RSAUtility.SignWithSHA256(_platformCertPk, plainText);

                            if (softSignRequired)
                            {
                                byte[] keyBytes = Convert.FromBase64String(_enterpriseCertPk);
                                byte[] msgBytes = Convert.FromBase64String(signText);
                                softSignText = Convert.ToBase64String(Utilities.RSAUtility.SignWithSHA256(keyBytes, msgBytes));
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exceptions.WechatTenpayBusinessRequestSignatureException("Failed to generate signature of request. Please see the inner exception for more details.", ex);
                        }
                    }
                    break;

                default:
                    throw new Exceptions.WechatTenpayBusinessRequestSignatureException("Unsupported authorization sign algorithm.");
            }

            string authString = $"platform_id=\"{_platformId}\",platform_serial_number=\"{_platformCertSn}\",nonce=\"{nonce}\",timestamp=\"{timestamp}\",signature=\"{signText}\",signature_algorithm=\"{_signAlg}\"";
            flurlCall.Request.Headers.Remove(HTTP_HEADER_PLATFORM_AUTHORIZATION);
            flurlCall.Request.WithHeader(HttpHeaders.Authorization, authString);

            if (softSignRequired)
            {
                string softAuthString = $"ent_id=\"{_enterpriseId}\",enterprise_serial_number=\"{_enterpriseCertSn}\",signature=\"{softSignText}\",signature_algorithm=\"{_signAlg}\"";
                flurlCall.Request.Headers.Remove(HTTP_HEADER_ENTERPRISE_AUTHORIZATION);
                flurlCall.Request.WithHeader(HTTP_HEADER_ENTERPRISE_AUTHORIZATION, softAuthString);
            }
        }
    }
}
