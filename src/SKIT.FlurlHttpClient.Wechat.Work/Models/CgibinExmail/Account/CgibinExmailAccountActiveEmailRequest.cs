namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/exmail/account/act_email 接口的请求。</para>
    /// </summary>
    public class CgibinExmailAccountActiveEmailRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string? UserId { get; set; }

        /// <summary>
        /// 获取或设置业务邮箱 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("publicemail_id")]
        [System.Text.Json.Serialization.JsonPropertyName("publicemail_id")]
        public int? PublicMailId { get; set; }

        /// <summary>
        /// 获取或设置操作列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int? Type { get; set; }
    }
}
