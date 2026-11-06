namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/reimburse/getinvoiceinfo 接口的响应。</para>
    /// </summary>
    public class CardInvoiceReimburseGetInvoiceInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public abstract class __zz__Invoice : CardInvoiceInsertRequest.Types.CardExtra.Types.InvoiceCard.Types.__zz__Invoice
            {
                /// <summary>
                /// 获取或设置发票报销状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reimburse_status")]
                [System.Text.Json.Serialization.JsonPropertyName("reimburse_status")]
                public string? ReimburseStatus { get; set; }

                /// <summary>
                /// 获取或设置发票文件 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pdf_url")]
                [System.Text.Json.Serialization.JsonPropertyName("pdf_url")]
                public string? PdfUrl { get; set; }

                /// <summary>
                /// 获取或设置其它消费附件 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trip_pdf_url")]
                [System.Text.Json.Serialization.JsonPropertyName("trip_pdf_url")]
                public string? TripUrl { get; set; }

                /// <summary>
                /// 获取或设置订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string? OrderId { get; set; }
            }

            public class Invoice : __zz__Invoice
            {
                public static class Types
                {
                    public class InvoiceItem : CardInvoiceInsertRequest.Types.CardExtra.Types.InvoiceCard.Types.Invoice.Types.InvoiceItem
                    {
                    }
                }

                /// <summary>
                /// 获取或设置发票行项目数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("info")]
                [System.Text.Json.Serialization.JsonPropertyName("info")]
                public List<Types.InvoiceItem>? InvoiceItemList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置发票卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string? CardId { get; set; }

        /// <summary>
        /// 获取或设置发票的有效期起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_time")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
        public long BeginTimestamp { get; set; }

        /// <summary>
        /// 获取或设置发票的有效期截止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置发票卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_card_status")]
        [System.Text.Json.Serialization.JsonPropertyName("user_card_status")]
        public string? CardStatus { get; set; }

        /// <summary>
        /// 获取或设置获得发票的用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置开票类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 获取或设置开票方全称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payee")]
        [System.Text.Json.Serialization.JsonPropertyName("payee")]
        public string? Payee { get; set; }

        /// <summary>
        /// 获取或设置开票详情。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail")]
        [System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// 获取或设置发票信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_info")]
        [System.Text.Json.Serialization.JsonPropertyName("user_info")]
        public Types.Invoice? Invoice { get; set; }
    }
}
