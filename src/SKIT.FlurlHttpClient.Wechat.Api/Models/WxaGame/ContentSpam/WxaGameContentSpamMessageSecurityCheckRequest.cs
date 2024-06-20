namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/game/content_spam/msg_sec_check 接口的请求。</para>
    /// </summary>
    public class WxaGameContentSpamMessageSecurityCheckRequest : WechatApiRequest, IInferable<WxaGameContentSpamMessageSecurityCheckRequest, WxaGameContentSpamMessageSecurityCheckResponse>
    {
        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nickname")]
        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
        public string? Nickname { get; set; }

        /// <summary>
        /// 获取或设置文本内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置版本号。
        /// <para>默认值：2</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version")]
        [System.Text.Json.Serialization.JsonPropertyName("version")]
        public int Version { get; set; } = 2;

        /// <summary>
        /// 获取或设置场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        [System.Text.Json.Serialization.JsonPropertyName("scene")]
        public int Scene { get; set; }
    }
}
