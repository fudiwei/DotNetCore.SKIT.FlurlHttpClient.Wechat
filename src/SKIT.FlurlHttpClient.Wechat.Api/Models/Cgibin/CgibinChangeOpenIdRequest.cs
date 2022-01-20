using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/changeopenid 接口的请求。</para>
    /// </summary>
    public class CgibinChangeOpenIdRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置原帐号的微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("from_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("from_appid")]
        public string FromAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置需要转换的用户 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("openid_list")]
        public IList<string> OpenIdList { get; set; } = new List<string>();
    }
}
