namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/auth/getuserinfo 接口的响应。</para>
    /// </summary>
    public class CgibinAuthGetUserInfoResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置成员 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string? UserId { get; set; }

        /// <summary>
        /// 获取或设置成员票据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("user_ticket")]
        public string? UserTicket { get; set; }

        /// <summary>
        /// 获取或设置非企业成员的标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置外部联系人 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
        public string? ExternalUserId { get; set; }
    }
}
