namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/getsnticket 接口的响应。</para>
    /// </summary>
    public class WxaGetSnTicketResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置设备票据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sn_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("sn_ticket")]
        public string SnTicket { get; set; } = default!;
    }
}
