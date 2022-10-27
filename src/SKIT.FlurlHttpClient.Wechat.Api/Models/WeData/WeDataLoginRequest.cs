namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wedata/wedata_login 接口的请求。</para>
    /// </summary>
    public class WeDataLoginRequest : WechatApiRequest, IInferable<WeDataLoginRequest, WeDataLoginResponse>
    {
        /// <summary>
        /// 获取或设置用户在服务商系统的唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uid")]
        [System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户在服务商系统的会话标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_session")]
        [System.Text.Json.Serialization.JsonPropertyName("user_session")]
        public string UserSession { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户 IP。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_ip")]
        [System.Text.Json.Serialization.JsonPropertyName("client_ip")]
        public string? ClientIp { get; set; }

        /// <summary>
        /// 获取或设置用户 UserAgent。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_agent")]
        [System.Text.Json.Serialization.JsonPropertyName("user_agent")]
        public string? UserAgent { get; set; }
    }
}
