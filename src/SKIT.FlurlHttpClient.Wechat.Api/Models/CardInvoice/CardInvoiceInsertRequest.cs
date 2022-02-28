using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/insert 接口的请求。</para>
    /// </summary>
    public class CardInvoiceInsertRequest : WechatApiRequest, IInferable<CardInvoiceInsertRequest, CardInvoiceInsertResponse>
    {
        public static class Types
        {
            public class CardExtra
            {
                public static class Types
                {
                    public class InvoiceCard
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
                                        public string Name { get; set; } = string.Empty;

                                        /// <summary>
                                        /// 获取或设置计量单位。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("unit")]
                                        [System.Text.Json.Serialization.JsonPropertyName("unit")]
                                        public string Unit { get; set; } = string.Empty;

                                        /// <summary>
                                        /// 获取或设置项目数量。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("num")]
                                        [System.Text.Json.Serialization.JsonPropertyName("num")]
                                        public int Count { get; set; }

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
                                public string Title { get; set; } = string.Empty;

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
                                public string InvoiceNumber { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置发票代码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("billing_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("billing_code")]
                                public string InvoiceCode { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置开票时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("billing_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("billing_time")]
                                public long DateTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置发票行项目数据列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("info")]
                                [System.Text.Json.Serialization.JsonPropertyName("info")]
                                public IList<Types.InvoiceItem> InvoiceItemList { get; set; } = new List<Types.InvoiceItem>();

                                /// <summary>
                                /// 获取或设置校验码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("check_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("check_code")]
                                public string CheckCode { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置发票文件标识。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("s_pdf_media_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("s_pdf_media_id")]
                                public string PdfSpMediaId { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置其它消费附件文件标识。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("s_trip_pdf_media_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("s_trip_pdf_media_id")]
                                public string? TripSpMediaId { get; set; }

                                /// <summary>
                                /// 获取或设置购买方纳税人识别号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("buyer_number")]
                                [System.Text.Json.Serialization.JsonPropertyName("buyer_number")]
                                public string BuyerTaxNumber { get; set; } = string.Empty;

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
                        /// 获取或设置发票信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("invoice_user_data")]
                        [System.Text.Json.Serialization.JsonPropertyName("invoice_user_data")]
                        public Types.Invoice Invoice { get; set; } = new Types.Invoice();
                    }
                }

                /// <summary>
                /// 获取或设置随机字符串。如果不指定将由系统自动生成。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nonce_str")]
                [System.Text.Json.Serialization.JsonPropertyName("nonce_str")]
                public string? Nonce { get; set; }

                /// <summary>
                /// 获取或设置用户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_card")]
                [System.Text.Json.Serialization.JsonPropertyName("user_card")]
                public Types.InvoiceCard InvoiceCard { get; set; } = new Types.InvoiceCard();
            }
        }

        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置发票卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置发票扩展信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_ext")]
        [System.Text.Json.Serialization.JsonPropertyName("card_ext")]
        public Types.CardExtra CardExtra { get; set; } = new Types.CardExtra();
    }
}
