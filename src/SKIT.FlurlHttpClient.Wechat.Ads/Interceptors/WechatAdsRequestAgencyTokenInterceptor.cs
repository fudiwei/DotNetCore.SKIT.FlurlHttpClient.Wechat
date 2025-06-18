using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Interceptors
{
    internal class WechatAdsRequestAgencyTokenInterceptor : HttpInterceptor
    {
        private readonly string _agencyId;
        private readonly string _agencyApiKey;

        public WechatAdsRequestAgencyTokenInterceptor(string agencyId, string agencyApiKey)
        {
            _agencyId = agencyId;
            _agencyApiKey = agencyApiKey;
        }

        public override async Task BeforeCallAsync(HttpInterceptorContext context, CancellationToken cancellationToken = default)
        {
            if (context is null) throw new ArgumentNullException(nameof(context));
            if (context.FlurlCall.Completed) throw new WechatAdsException("Failed to sign request. This interceptor must be called before request completed.");

            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string sign = Utilities.MD5Utility.Hash($"{_agencyId}{timestamp}{nonce}{_agencyApiKey}").Value!.ToLower();
            string token = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{_agencyId},{timestamp},{nonce},{sign}"));

            context.FlurlCall.Request.SetQueryParam("agency_token", token);

            await Task.Yield();
        }
    }
}
