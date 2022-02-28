namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/queryinvoceinfo 接口的请求。</para>
    /// </summary>
    public class CardInvoiceQueryInvoiceInfoRequest : WechatApiRequest, IMapResponse<CardInvoiceQueryInvoiceInfoRequest, CardInvoiceQueryInvoiceInfoResponse>
    {
        /// <summary>
        /// 获取或设置发票请求流水号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fpqqlsh")]
        [System.Text.Json.Serialization.JsonPropertyName("fpqqlsh")]
        public string InvoiceSerialNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置纳税人识别码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nsrsbh")]
        [System.Text.Json.Serialization.JsonPropertyName("nsrsbh")]
        public string SellerTaxNumber { get; set; } = string.Empty;
    }
}
