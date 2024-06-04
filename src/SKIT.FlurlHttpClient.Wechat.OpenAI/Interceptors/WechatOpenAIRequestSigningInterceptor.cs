using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Interceptors
{
    using SKIT.FlurlHttpClient.Internal;

    internal class WechatOpenAIRequestSigningInterceptor : HttpInterceptor
    {
        private readonly string _token;

        public WechatOpenAIRequestSigningInterceptor(string token)
        {
            _token = token;
        }

        public override async Task BeforeCallAsync(HttpInterceptorContext context, CancellationToken cancellationToken = default)
        {
            if (context is null) throw new ArgumentNullException(nameof(context));
            if (context.FlurlCall.Completed) throw new WechatOpenAIException("Failed to sign request. This interceptor must be called before request completed.");

            if (context.FlurlCall.HttpRequestMessage.RequestUri is null)
                return;

            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string body = string.Empty;
            if (context.FlurlCall.HttpRequestMessage?.Content is not null)
            {
                if (context.FlurlCall.HttpRequestMessage.Content is MultipartFormDataContent)
                {
                    body = string.Empty;
                }
                else
                {
                    body = await
#if NET5_0_OR_GREATER
                    context.FlurlCall.HttpRequestMessage.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
#else
                    _AsyncEx.RunTaskWithCancellationTokenAsync(context.FlurlCall.HttpRequestMessage.Content.ReadAsStringAsync(), cancellationToken).ConfigureAwait(false);
#endif
                }
            }

            string signData = $"{_token}{timestamp}{nonce}{Utilities.MD5Utility.Hash(body).Value!.ToLower()}";
            string sign = Utilities.MD5Utility.Hash(signData).Value!.ToLower();

            context.FlurlCall.Request.WithHeader("timestamp", timestamp);
            context.FlurlCall.Request.WithHeader("nonce", nonce);
            context.FlurlCall.Request.WithHeader("sign", sign);
        }
    }
}
