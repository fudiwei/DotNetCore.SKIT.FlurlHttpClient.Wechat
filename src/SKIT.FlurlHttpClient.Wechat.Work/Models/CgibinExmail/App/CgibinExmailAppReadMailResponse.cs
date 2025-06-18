namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/exmail/app/read_mail 接口的响应。</para>
    /// </summary>
    public class CgibinExmailAppReadMailResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置邮件 EML 内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mail_data")]
        [System.Text.Json.Serialization.JsonPropertyName("mail_data")]
        public string MailData { get; set; } = default!;
    }
}
