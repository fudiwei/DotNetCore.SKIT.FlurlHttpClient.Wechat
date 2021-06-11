using System;
using System.Linq;
using System.Text;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Interceptors
{
    internal class WechatAdsAuthenticator
    {
        private readonly string _agencyId;
        private readonly string _agencyApiKey;

        public WechatAdsAuthenticator(string agencyId, string agencyApiKey)
        {
            _agencyId = agencyId;
            _agencyApiKey = agencyApiKey;
        }

        public void Authenticate(FlurlCall flurlCall)
        {
            if (flurlCall == null) throw new ArgumentNullException(nameof(flurlCall));

            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string sign = Security.MD5Utility.Hash($"{_agencyId}{timestamp}{nonce}{_agencyApiKey}").ToLower();
            string token = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{_agencyId},{timestamp},{nonce},{sign}"));

            flurlCall.Request.RemoveQueryParam("agency_token");
            flurlCall.Request.SetQueryParam("agency_token", token);
        }
    }
}
