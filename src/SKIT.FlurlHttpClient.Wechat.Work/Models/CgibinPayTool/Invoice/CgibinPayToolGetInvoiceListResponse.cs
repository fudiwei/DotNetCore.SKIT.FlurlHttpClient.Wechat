namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/paytool/get_invoice_list 接口的响应。</para>
    /// </summary>
    public class CgibinPayToolGetInvoiceListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Invoice
            {
                /// <summary>
                /// 获取或设置开票订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置客户企业 CorpId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_corpid")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_corpid")]
                public string? CustomCorpId { get; set; }

                /// <summary>
                /// 获取或设置申请开票时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_time")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_time")]
                public long ApplyTimestamp { get; set; }

                /// <summary>
                /// 获取或设置发票类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invoice_type")]
                [System.Text.Json.Serialization.JsonPropertyName("invoice_type")]
                public int InvoiceType { get; set; }

                /// <summary>
                /// 获取或设置实付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("paid_price")]
                [System.Text.Json.Serialization.JsonPropertyName("paid_price")]
                public int PaidPrice { get; set; }

                /// <summary>
                /// 获取或设置开票状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invoice_status")]
                [System.Text.Json.Serialization.JsonPropertyName("invoice_status")]
                public int InvoiceStatus { get; set; }

                /// <summary>
                /// 获取或设置发票抬头。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invoice_title")]
                [System.Text.Json.Serialization.JsonPropertyName("invoice_title")]
                public string InvoiceTitle { get; set; } = default!;

                /// <summary>
                /// 获取或设置纳税人识别号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tax_number")]
                [System.Text.Json.Serialization.JsonPropertyName("tax_number")]
                public string TaxNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置发票收取方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("send_way")]
                [System.Text.Json.Serialization.JsonPropertyName("send_way")]
                public int SendWay { get; set; }

                /// <summary>
                /// 获取或设置联系人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_name")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_name")]
                public string? ContactName { get; set; }

                /// <summary>
                /// 获取或设置联系电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_tel")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_tel")]
                public string? ContactTeleNumber { get; set; }

                /// <summary>
                /// 获取或设置收件地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_addr")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_addr")]
                public string? ContactAddress { get; set; }

                /// <summary>
                /// 获取或设置邮政编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_postcode")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_postcode")]
                public string? ContactPostCode { get; set; }

                /// <summary>
                /// 获取或设置电子邮箱。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receive_email")]
                [System.Text.Json.Serialization.JsonPropertyName("receive_email")]
                public string? ReceiveEmail { get; set; }

                /// <summary>
                /// 获取或设置公司地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_addr")]
                [System.Text.Json.Serialization.JsonPropertyName("company_addr")]
                public string CompanyAddress { get; set; } = default!;

                /// <summary>
                /// 获取或设置公司电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_tel")]
                [System.Text.Json.Serialization.JsonPropertyName("company_tel")]
                public string CompanyTeleNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置开户行。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
                public string BankName { get; set; } = default!;

                /// <summary>
                /// 获取或设置银行账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_account_number")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_account_number")]
                public string BankAccountNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置开票备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invoice_note")]
                [System.Text.Json.Serialization.JsonPropertyName("invoice_note")]
                public string InvoiceNotes { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置发票列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invoice_list")]
        [System.Text.Json.Serialization.JsonPropertyName("invoice_list")]
        public Types.Invoice[] InvoiceList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool HasMore { get; set; }
    }
}
