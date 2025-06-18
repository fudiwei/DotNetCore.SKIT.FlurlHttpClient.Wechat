namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/exmail/app/read_mail 接口的请求。</para>
    /// </summary>
    public class CgibinExmailAppReadMailRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置邮件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mail_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mail_id")]
        public string MailId { get; set; } = string.Empty;
    }
}
