using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Interceptors
{
    internal class WechatTenpayBusinessRequestSignatureInterceptor : FlurlHttpCallInterceptor
    {
        private readonly string _signAlg;
        private readonly string _platformId;
        private readonly string _platformCertSn;
        private readonly string _platformCertPk;

        public WechatTenpayBusinessRequestSignatureInterceptor(string signAlg, string platformId, string platformCertSn, string platformCertPk)
        {
            _signAlg = signAlg;
            _platformId = platformId;
            _platformCertSn = platformCertSn;
            _platformCertPk = platformCertPk;
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

            switch (_signAlg)
            {
                case Constants.SignAlgorithms.SHA245_WITH_RSA:
                    {
                        try
                        {
                            signText = Utilities.RSAUtility.SignWithSHA256(_platformCertPk, plainText);
                        }
                        catch (Exception ex)
                        {
                            throw new Exceptions.WechatTenpayBusinessRequestSignatureException("Generate signature of request failed. Please see the `InnerException` for more details.", ex);
                        }
                    }
                    break;

                default:
                    throw new Exceptions.WechatTenpayBusinessRequestSignatureException("Unsupported authorization sign algorithm.");
            }

            string auth = $"platform_id=\"{_platformId}\",platform_serial_number=\"{_platformCertSn}\",nonce=\"{nonce}\",timestamp=\"{timestamp}\",signature=\"{signText}\",signature_algorithm=\"{_signAlg}\"";
            flurlCall.Request.Headers.Remove(FlurlHttpClient.Constants.HttpHeaders.Authorization);
            flurlCall.Request.WithHeader(FlurlHttpClient.Constants.HttpHeaders.Authorization, $"{_signAlg} {auth}");
        }
    }
}
