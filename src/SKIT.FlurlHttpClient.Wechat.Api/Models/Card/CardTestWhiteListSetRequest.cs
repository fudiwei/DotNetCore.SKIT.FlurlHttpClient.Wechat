using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/testwhitelist/set 接口的请求。</para>
    /// </summary>
    public class CardTestWhiteListSetRequest : WechatApiRequest, IMapResponse<CardTestWhiteListSetRequest, CardTestWhiteListSetResponse>
    {
        /// <summary>
        /// 获取或设置测试用户的 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public IList<string>? OpenIdList { get; set; }

        /// <summary>
        /// 获取或设置测试用户的微信号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("username")]
        [System.Text.Json.Serialization.JsonPropertyName("username")]
        public IList<string>? UsernameList { get; set; }
    }
}
