namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/ticket/get 接口的响应。</para>
    /// </summary>
    public class CgibinTicketGetResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置票据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("ticket")]
        public string? Ticket { get; set; }

        /// <summary>
        /// 获取或设置票据有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
    }
}
