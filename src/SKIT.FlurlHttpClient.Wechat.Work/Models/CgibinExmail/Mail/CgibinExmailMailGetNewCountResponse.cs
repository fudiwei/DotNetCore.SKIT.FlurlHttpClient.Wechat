namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/exmail/mail/get_newcount 接口的响应。</para>
    /// </summary>
    public class CgibinExmailMailGetNewCountResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置新邮件数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public int NewCount { get; set; }
    }
}
