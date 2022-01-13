using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Flurl;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientParameterExtensions
    {
        /// <summary>
        /// <para>生成企业号 JS-SDK `wx.config` 所需的参数字典。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90506 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90539 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90777 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="jsapiTicket"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForJSSDKConfig(this WechatWorkClient client, string jsapiTicket, string url)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (jsapiTicket is null) throw new ArgumentNullException(nameof(jsapiTicket));
            if (url is null) throw new ArgumentNullException(nameof(url));

            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string sign = Utilities.SHA1Utility.Hash($"jsapi_ticket={jsapiTicket}&noncestr={nonce}&timestamp={timestamp}&url={url.Split('#')[0]}").ToLower();

            return new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
            {
                { "appId", client.Credentials.CorpId },
                { "timestamp", timestamp },
                { "nonceStr", nonce },
                { "signature", sign }
            });
        }

        /// <summary>
        /// <para>生成企业号 JS-SDK `wx.agentConfig` 所需的参数字典。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90506 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90539 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90777 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="jsapiTicket"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForJSSDKAgentConfig(this WechatWorkClient client, string jsapiTicket, string url)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (jsapiTicket is null) throw new ArgumentNullException(nameof(jsapiTicket));
            if (url is null) throw new ArgumentNullException(nameof(url));

            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string sign = Utilities.SHA1Utility.Hash($"jsapi_ticket={jsapiTicket}&noncestr={nonce}&timestamp={timestamp}&url={url.Split('#')[0]}").ToLower();

            return new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
            {
                { "corpid", client.Credentials.CorpId },
                { "agentid", client.Credentials.AgentId?.ToString() ?? string.Empty },
                { "timestamp", timestamp },
                { "nonceStr", nonce },
                { "signature", sign }
            });
        }

        /// <summary>
        /// <para>生成企业号网页授权 URL。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91022 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91120 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="scope"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static string GenerateParameterizedUrlForConnectOAuth2Authorize(this WechatWorkClient client, string redirectUrl, string scope, string? state = null)
        {
            return new Url("https://open.weixin.qq.com")
                .AppendPathSegments("connect", "oauth2", "authorize")
                .SetQueryParam("appid", string.IsNullOrEmpty(client.Credentials.SuiteId) ? client.Credentials.CorpId : client.Credentials.SuiteId)
                .SetQueryParam("redirect_uri", redirectUrl)
                .SetQueryParam("response_type", "code")
                .SetQueryParam("scope", scope)
                .SetQueryParam("state", state)
                .SetFragment("wechat_redirect")
                .ToString();
        }

        /// <summary>
        /// <para>生成企业号扫码授权 URL。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91019 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91124 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="state"></param>
        /// <param name="language"></param>
        /// <param name="userType"></param>
        /// <returns></returns>
        public static string GenerateParameterizedUrlForSSOQrcodeConnectAuthorize(this WechatWorkClient client, string redirectUrl, string? state = null, string? language = null, string? userType = null)
        {
            return new Url("https://open.work.weixin.qq.com")
                .AppendPathSegments("wwopen", "sso", "qrConnect")
                .SetQueryParam("appid", client.Credentials.CorpId)
                .SetQueryParam("agentid", client.Credentials.AgentId)
                .SetQueryParam("redirect_uri", redirectUrl)
                .SetQueryParam("state", state)
                .SetQueryParam("lang", language)
                .SetQueryParam("usertype", userType)
                .ToString();
        }
    }
}
