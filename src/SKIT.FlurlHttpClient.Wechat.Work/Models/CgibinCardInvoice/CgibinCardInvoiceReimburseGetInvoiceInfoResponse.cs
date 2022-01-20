namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/card/invoice/reimburse/getinvoiceinfo 接口的响应。</para>
    /// </summary>
    public class CgibinCardInvoiceReimburseGetInvoiceInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Invoice
            {
                public static class Types
                {
                    public class InvoiceItem
                    {
                        /// <summary>
                        /// 获取或设置项目名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置计量单位。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unit")]
                        [System.Text.Json.Serialization.JsonPropertyName("unit")]
                        public string? Unit { get; set; }

                        /// <summary>
                        /// 获取或设置项目数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("num")]
                        [System.Text.Json.Serialization.JsonPropertyName("num")]
                        public int? Count { get; set; }

                        /// <summary>
                        /// 获取或设置项目单价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price")]
                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                        public int Price { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置发票抬头。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置不含税金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fee_without_tax")]
                [System.Text.Json.Serialization.JsonPropertyName("fee_without_tax")]
                public int FeeWithoutTax { get; set; }

                /// <summary>
                /// 获取或设置发票金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fee")]
                [System.Text.Json.Serialization.JsonPropertyName("fee")]
                public int Fee { get; set; }

                /// <summary>
                /// 获取或设置税额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tax")]
                [System.Text.Json.Serialization.JsonPropertyName("tax")]
                public int Tax { get; set; }

                /// <summary>
                /// 获取或设置发票号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("billing_no")]
                [System.Text.Json.Serialization.JsonPropertyName("billing_no")]
                public string InvoiceCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置发票代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("billing_code")]
                [System.Text.Json.Serialization.JsonPropertyName("billing_code")]
                public string InvoiceNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置开票时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("billing_time")]
                [System.Text.Json.Serialization.JsonPropertyName("billing_time")]
                public long InvoiceTimestamp { get; set; }

                /// <summary>
                /// 获取或设置发票行项目数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("info")]
                [System.Text.Json.Serialization.JsonPropertyName("info")]
                public Types.InvoiceItem[]? InvoiceItemList { get; set; }

                /// <summary>
                /// 获取或设置校验码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("check_code")]
                [System.Text.Json.Serialization.JsonPropertyName("check_code")]
                public string CheckCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置发票详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail")]
                [System.Text.Json.Serialization.JsonPropertyName("detail")]
                public string Detail { get; set; } = default!;

                /// <summary>
                /// 获取或设置发票报销状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reimburse_status")]
                [System.Text.Json.Serialization.JsonPropertyName("reimburse_status")]
                public string ReimburseStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置发票文件 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pdf_url")]
                [System.Text.Json.Serialization.JsonPropertyName("pdf_url")]
                public string PdfUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置其它消费附件 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trip_pdf_url")]
                [System.Text.Json.Serialization.JsonPropertyName("trip_pdf_url")]
                public string? TripUrl { get; set; }

                /// <summary>
                /// 获取或设置购买方纳税人识别号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("buyer_number")]
                [System.Text.Json.Serialization.JsonPropertyName("buyer_number")]
                public string BuyerTaxNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置购买方地址、电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("buyer_address_and_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("buyer_address_and_phone")]
                public string? BuyerAddressAndPhoneNumber { get; set; }

                /// <summary>
                /// 获取或设置购买方开户行、银行账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("buyer_bank_account")]
                [System.Text.Json.Serialization.JsonPropertyName("buyer_bank_account")]
                public string? BuyerBankAccount { get; set; }

                /// <summary>
                /// 获取或设置销售方纳税人识别号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("seller_number")]
                [System.Text.Json.Serialization.JsonPropertyName("seller_number")]
                public string? SellerTaxNumber { get; set; }

                /// <summary>
                /// 获取或设置销售方纳税人地址、电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("seller_address_and_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("seller_address_and_phone")]
                public string? SellerAddressAndPhoneNumber { get; set; }

                /// <summary>
                /// 获取或设置销售方开户行、银行账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("seller_bank_account")]
                [System.Text.Json.Serialization.JsonPropertyName("seller_bank_account")]
                public string? SellerBankAccount { get; set; }

                /// <summary>
                /// 获取或设置备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remarks")]
                [System.Text.Json.Serialization.JsonPropertyName("remarks")]
                public string? Remark { get; set; }

                /// <summary>
                /// 获取或设置开票人。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("maker")]
                [System.Text.Json.Serialization.JsonPropertyName("maker")]
                public string? Drawer { get; set; }

                /// <summary>
                /// 获取或设置收款人。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cashier")]
                [System.Text.Json.Serialization.JsonPropertyName("cashier")]
                public string? Cashier { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置发票卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = default!;

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
        /// 获取或设置获得发票的用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置开票类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 获取或设置开票方全称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payee")]
        [System.Text.Json.Serialization.JsonPropertyName("payee")]
        public string Payee { get; set; } = default!;

        /// <summary>
        /// 获取或设置开票详情。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail")]
        [System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string Detail { get; set; } = default!;

        /// <summary>
        /// 获取或设置发票信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_info")]
        [System.Text.Json.Serialization.JsonPropertyName("user_info")]
        public Types.Invoice Invoice { get; set; } = default!;
    }
}
