using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.SpecialApi.Interceptors
{
    using System.Text;
    using SKIT.FlurlHttpClient;
    using SKIT.FlurlHttpClient.Internal;
    using SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.SpecialApi;

    internal class WechatWorkSpecialApiRequestSigningInterceptor : HttpInterceptor
    {
        private readonly string _secret;

        public WechatWorkSpecialApiRequestSigningInterceptor(string secret)
        {
            _secret = secret;
        }

        public override async Task BeforeCallAsync(HttpInterceptorContext context, CancellationToken cancellationToken = default)
        {
            if (context is null) throw new ArgumentNullException(nameof(context));
            if (context.FlurlCall.Completed) throw new WechatWorkSpecialApiException("Failed to sign request. This interceptor must be called before request completed.");

            string method = context.FlurlCall.HttpRequestMessage.Method.ToString().ToUpper();
            string path = context.FlurlCall.HttpRequestMessage.RequestUri?.AbsolutePath ?? string.Empty;
            string query = context.FlurlCall.HttpRequestMessage.RequestUri?.Query?.TrimStart('?') ?? string.Empty;
            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string authCorpId = context.FlurlCall.Request.Headers.GetAll("auth-corpid").FirstOrDefault() ?? string.Empty;
            string body = string.Empty;

            if (context.FlurlCall.HttpRequestMessage?.Content is not null)
            {
                if (method != "GET")
                {
                    HttpContent httpContent = context.FlurlCall.HttpRequestMessage.Content;
                    body = await _AsyncEx.RunTaskWithCancellationTokenAsync(httpContent.ReadAsStringAsync(), cancellationToken).ConfigureAwait(false);
                }
            }

            StringBuilder signData = new StringBuilder();
            signData.Append(!string.IsNullOrEmpty(authCorpId) ? $"auth-corpid={authCorpId}\n" : string.Empty);
            signData.Append($"body-md5={Utilities.MD5Utility.Hash(body).Value!.ToLower()}\n");
            signData.Append($"timestamp={timestamp}\n");
            signData.Append($"method={method}\n");
            signData.Append($"nonce={nonce}\n");
            signData.Append($"url={path}\n");
            signData.Append(!string.IsNullOrEmpty(query) ? $"query={query}\n" : string.Empty);
            signData.Append("\n");
            string sign;

            try
            {
                sign = Utilities.HMACUtility.HashWithSHA256(_secret, signData.ToString()).Value!.ToLower();
            }
            catch (Exception ex)
            {
                throw new WechatWorkSpecialApiException("Failed to sign request. Please see the inner exception for more details.", ex);
            }

            context.FlurlCall.Request.WithHeader("nonce", nonce);
            context.FlurlCall.Request.WithHeader("timestamp", timestamp);
            context.FlurlCall.Request.WithHeader("signature", sign);
        }
    }
}
