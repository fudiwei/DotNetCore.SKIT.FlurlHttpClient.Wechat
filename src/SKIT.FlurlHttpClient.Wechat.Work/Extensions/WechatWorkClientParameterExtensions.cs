using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Flurl;
using static SKIT.FlurlHttpClient.Wechat.Work.Models.CgibinSchoolAgentGetAllowScopeResponse.Types;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientParameterExtensions
    {
        private const string BASE_URL_OPEN = "https://open.weixin.qq.com/";
        private const string BASE_URL_OPENWORK = "https://open.work.weixin.qq.com/";

        /// <summary>
        /// <para>生成企业微信 JS-SDK `wx.config` 所需的参数字典。</para>
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
        /// <para>生成企业微信 JS-SDK `wx.agentConfig` 所需的参数字典。</para>
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
        /// <para>生成企业微信网页授权 URL。</para>
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
            return GenerateParameterizedUrlForConnectOAuth2Authorize(client, agentId: client.Credentials.AgentId.GetValueOrDefault(), redirectUrl: redirectUrl, scope: scope, state: state);
        }

        /// <summary>
        /// <para>生成企业微信网页授权 URL。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91022 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91120 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="agentId"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="scope"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static string GenerateParameterizedUrlForConnectOAuth2Authorize(this WechatWorkClient client, int agentId, string redirectUrl, string scope, string? state = null)
        {
            return new Url(BASE_URL_OPEN)
                .AppendPathSegments("connect", "oauth2", "authorize")
                .SetQueryParam("appid", string.IsNullOrEmpty(client.Credentials.SuiteId) ? client.Credentials.CorpId : client.Credentials.SuiteId)
                .SetQueryParam("redirect_uri", redirectUrl)
                .SetQueryParam("response_type", "code")
                .SetQueryParam("scope", scope)
                .SetQueryParam("state", state)
                .SetQueryParam("agentid", agentId)
                .SetFragment("wechat_redirect")
                .ToString();
        }

        /// <summary>
        /// <para>生成企业微信扫码授权 URL。</para>
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
            return GenerateParameterizedUrlForSSOQrcodeConnectAuthorize(client, agentId: client.Credentials.AgentId.GetValueOrDefault(), redirectUrl: redirectUrl, state: state, language: language, userType: userType);
        }

        /// <summary>
        /// <para>生成企业微信扫码授权 URL。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91019 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91124 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="agentId"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="state"></param>
        /// <param name="language"></param>
        /// <param name="userType"></param>
        /// <returns></returns>
        public static string GenerateParameterizedUrlForSSOQrcodeConnectAuthorize(this WechatWorkClient client, int agentId, string redirectUrl, string? state = null, string? language = null, string? userType = null)
        {
            return new Url(BASE_URL_OPENWORK)
                .AppendPathSegments("wwopen", "sso", "qrConnect")
                .SetQueryParam("appid", client.Credentials.CorpId)
                .SetQueryParam("agentid", agentId)
                .SetQueryParam("redirect_uri", redirectUrl)
                .SetQueryParam("state", state)
                .SetQueryParam("lang", language)
                .SetQueryParam("usertype", userType)
                .ToString();
        }

        /// <summary>
        /// <para>生成企业微信第三方单点登录扫码授权 URL。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/10991 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="state"></param>
        /// <param name="userType"></param>
        /// <returns></returns>
        public static string GenerateParameterizedUrlForSSO3rdQrcodeConnectAuthorize(this WechatWorkClient client, string redirectUrl, string? state = null, string? userType = null)
        {
            return new Url(BASE_URL_OPENWORK)
                .AppendPathSegments("wwopen", "sso", "3rd_qrConnect")
                .SetQueryParam("appid", client.Credentials.CorpId)
                .SetQueryParam("redirect_uri", redirectUrl)
                .SetQueryParam("state", state)
                .SetQueryParam("usertype", userType)
                .ToString();
        }
    }
}
