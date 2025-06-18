namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/exmail/publicmail/search 接口的响应。</para>
    /// </summary>
    public class CgibinExmailPublicMailSearchResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Mail
            {
                /// <summary>
                /// 获取或设置业务邮箱 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public int Id { get; set; }

                /// <summary>
                /// 获取或设置业务邮箱地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("email")]
                [System.Text.Json.Serialization.JsonPropertyName("email")]
                public string Email { get; set; } = default!;

                /// <summary>
                /// 获取或设置业务邮箱名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置业务邮箱列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Mail[] MailList { get; set; } = default!;
    }
}
