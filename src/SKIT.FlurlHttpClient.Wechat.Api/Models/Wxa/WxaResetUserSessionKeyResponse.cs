namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/resetusersessionkey 接口的响应。</para>
    /// </summary>
    public class WxaResetUserSessionKeyResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置重置后的会话密钥。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("session_key")]
        [System.Text.Json.Serialization.JsonPropertyName("session_key")]
        public string SessionKey { get; set; } = default!;
    }
}
