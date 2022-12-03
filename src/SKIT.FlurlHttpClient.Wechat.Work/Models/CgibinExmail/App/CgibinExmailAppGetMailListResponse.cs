namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/exmail/app/get_mail_list 接口的响应。</para>
    /// </summary>
    public class CgibinExmailAppGetMailListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Mail
            {
                /// <summary>
                /// 获取或设置邮件 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mail_id")]
                [System.Text.Json.Serialization.JsonPropertyName("mail_id")]
                public string MailId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置分组列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mail_list")]
        [System.Text.Json.Serialization.JsonPropertyName("mail_list")]
        public Types.Mail[] MailList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
