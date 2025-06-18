namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/queryinvoceinfo 接口的响应。</para>
    /// </summary>
    public class CardInvoiceQueryInvoiceInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Invoice
            {
                /// <summary>
                /// 获取或设置发票请求流水号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fpqqlsh")]
                [System.Text.Json.Serialization.JsonPropertyName("fpqqlsh")]
                public string InvoiceSerialNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置发票代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fpdm")]
                [System.Text.Json.Serialization.JsonPropertyName("fpdm")]
                public string InvoiceCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置发票号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fphm")]
                [System.Text.Json.Serialization.JsonPropertyName("fphm")]
                public string InvoiceNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置开票日期字符串（格式：yyyyMMddHHmmss）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("kprq")]
                [System.Text.Json.Serialization.JsonPropertyName("kprq")]
                public string InvoiceDateTimeString { get; set; } = default!;

                /// <summary>
                /// 获取或设置校验码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("jym")]
                [System.Text.Json.Serialization.JsonPropertyName("jym")]
                public string CheckCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置发票的 PDF 文件 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pdfurl")]
                [System.Text.Json.Serialization.JsonPropertyName("pdfurl")]
                public string PdfUrl { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置发票信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invoicedetail")]
        [System.Text.Json.Serialization.JsonPropertyName("invoicedetail")]
        public Types.Invoice Invoice { get; set; } = default!;
    }
}
