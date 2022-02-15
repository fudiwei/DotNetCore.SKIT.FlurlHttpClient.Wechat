namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/clearoutinvoice 接口的请求。</para>
    /// </summary>
    public class CardInvoiceClearOutInvoiceRequest : WechatApiRequest, IMapResponse<CardInvoiceClearOutInvoiceRequest, CardInvoiceClearOutInvoiceResponse>
    {
        public static class Types
        {
            public class Invoice
            {
                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wxopenid")]
                [System.Text.Json.Serialization.JsonPropertyName("wxopenid")]
                public string OpenId { get; set; } = string.Empty;

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

                /// <summary>
                /// 获取或设置纳税人名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nsrmc")]
                [System.Text.Json.Serialization.JsonPropertyName("nsrmc")]
                public string SellerName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置原发票代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("yfpdm")]
                [System.Text.Json.Serialization.JsonPropertyName("yfpdm")]
                public string OriginalInvoiceCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置原发票号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("yfphm")]
                [System.Text.Json.Serialization.JsonPropertyName("yfphm")]
                public string OriginalInvoiceNumber { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置发票信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invoiceinfo")]
        [System.Text.Json.Serialization.JsonPropertyName("invoiceinfo")]
        public Types.Invoice Invoice { get; set; } = new Types.Invoice();
    }
}
