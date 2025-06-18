namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/seturl 接口的响应。</para>
    /// </summary>
    public class CardInvoiceSetUrlResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置授权链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invoice_url")]
        [System.Text.Json.Serialization.JsonPropertyName("invoice_url")]
        public string InvoiceUrl { get; set; } = default!;
    }
}
