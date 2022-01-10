using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Flurl;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientParameterExtensions
    {
        private const string BASE_URL = "https://open.weixin.qq.com/";

        /// <summary>
        /// <para>生成客户端 JS-SDK `wx.config` 所需的参数。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/OA_Web_Apps/JS-SDK.html#62 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="jsapiTicket"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForJSSDKConfig(this WechatApiClient client, string jsapiTicket, string url)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (jsapiTicket is null) throw new ArgumentNullException(nameof(jsapiTicket));
            if (url is null) throw new ArgumentNullException(nameof(url));

            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string sign = Utilities.SHA1Utility.Hash($"jsapi_ticket={jsapiTicket}&noncestr={nonce}&timestamp={timestamp}&url={url.Split('#')[0]}").ToLower();

            return new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
            {
                { "appId", client.Credentials.AppId },
                { "timestamp", timestamp },
                { "nonceStr", nonce },
                { "signature", sign }
            });
        }

        /// <summary>
        /// <para>生成客户端 JS-SDK `wx.chooseInvoice` 接口所需的参数。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/Auto-print/API_Documentation.html#_6-4-%E5%8F%91%E7%A5%A8%E7%AD%BE%E5%90%8D%E6%96%B9%E6%B3%95 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="wxcardTicket"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForJSSDKChooseInvoice(this WechatApiClient client, string wxcardTicket)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (wxcardTicket is null) throw new ArgumentNullException(nameof(wxcardTicket));

            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string cardType = "INVOICE";

            ISet<string> sortedParams = new SortedSet<string>(StringComparer.Ordinal);
            sortedParams.Add(cardType);
            sortedParams.Add(timestamp);
            sortedParams.Add(client.Credentials.AppId);
            sortedParams.Add(nonce);
            sortedParams.Add(wxcardTicket);
            string cardSign = Utilities.SHA1Utility.Hash(string.Join(string.Empty, sortedParams)).ToLower();

            return new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
            {
                { "timestamp", timestamp },
                { "nonceStr", nonce },
                { "signType", "SHA1" },
                { "cardType", cardType },
                { "cardSign", cardSign }
            });
        }

        /// <summary>
        /// <para>生成公众号网页授权 URL。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/OA_Web_Apps/Wechat_webpage_authorization.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="scope"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static string GenerateParameterizedUrlForConnectOAuth2Authorize(this WechatApiClient client, string redirectUrl, string scope, string? state = null)
        {
            return new Url(BASE_URL)
                .AppendPathSegments("connect", "oauth2", "authorize")
                .SetQueryParam("appid", client.Credentials.AppId)
                .SetQueryParam("redirect_uri", redirectUrl)
                .SetQueryParam("response_type", "code")
                .SetQueryParam("scope", scope)
                .SetQueryParam("state", state)
                .SetFragment("wechat_redirect")
                .ToString();
        }

        /// <summary>
        /// <para>生成代公众号网页授权 URL。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/Before_Develop/Official_Accounts/official_account_website_authorization.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="appId"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="scope"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static string GenerateParameterizedUrlForComponentConnectOAuth2Authorize(this WechatApiClient client, string appId, string redirectUrl, string scope, string? state = null)
        {
            return new Url(BASE_URL)
                .AppendPathSegments("connect", "oauth2", "authorize")
                .SetQueryParam("appid", appId)
                .SetQueryParam("component_appid", client.Credentials.AppId)
                .SetQueryParam("redirect_uri", redirectUrl)
                .SetQueryParam("response_type", "code")
                .SetQueryParam("scope", scope)
                .SetQueryParam("state", state)
                .SetFragment("wechat_redirect")
                .ToString();
        }
    }
}
