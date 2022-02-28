namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /intp/marketcode/tickettocode 接口的请求。</para>
    /// </summary>
    public class IntpMarketCodeTicketToCodeRequest : WechatApiRequest, IInferable<IntpMarketCodeTicketToCodeRequest, IntpMarketCodeTicketToCodeResponse>
    {
        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置跳转时的 Ticket。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("code_ticket")]
        public string CodeTicket { get; set; } = string.Empty;
    }
}
