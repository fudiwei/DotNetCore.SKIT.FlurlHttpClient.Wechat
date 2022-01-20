using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/makeoutinvoice 接口的请求。</para>
    /// </summary>
    public class CardInvoiceMakeOutInvoiceRequest : WechatApiRequest
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
                        /// 获取或设置发票行性质。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fphxz")]
                        [System.Text.Json.Serialization.JsonPropertyName("fphxz")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置税收分类编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spbm")]
                        [System.Text.Json.Serialization.JsonPropertyName("spbm")]
                        public string GoodsCode { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置项目名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("xmmc")]
                        [System.Text.Json.Serialization.JsonPropertyName("xmmc")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置计量单位。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("dw")]
                        [System.Text.Json.Serialization.JsonPropertyName("dw")]
                        public string Unit { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置规格型号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ggxh")]
                        [System.Text.Json.Serialization.JsonPropertyName("ggxh")]
                        public string Specification { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置项目数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("xmsl")]
                        [System.Text.Json.Serialization.JsonPropertyName("xmsl")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int Count { get; set; }

                        /// <summary>
                        /// 获取或设置项目单价（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("xmdj")]
                        [System.Text.Json.Serialization.JsonPropertyName("xmdj")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public double Price { get; set; }

                        /// <summary>
                        /// 获取或设置项目金额（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("xmje")]
                        [System.Text.Json.Serialization.JsonPropertyName("xmje")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public double Amount { get; set; }

                        /// <summary>
                        /// 获取或设置税率。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sl")]
                        [System.Text.Json.Serialization.JsonPropertyName("sl")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public double TaxRate { get; set; }

                        /// <summary>
                        /// 获取或设置税额（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("se")]
                        [System.Text.Json.Serialization.JsonPropertyName("se")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public double Tax { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wxopenid")]
                [System.Text.Json.Serialization.JsonPropertyName("wxopenid")]
                public string OpenId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ddh")]
                [System.Text.Json.Serialization.JsonPropertyName("ddh")]
                public string OrderId { get; set; } = string.Empty;

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
                /// 获取或设置纳税人地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nsrdz")]
                [System.Text.Json.Serialization.JsonPropertyName("nsrdz")]
                public string SellerAddress { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置纳税人电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nsrdh")]
                [System.Text.Json.Serialization.JsonPropertyName("nsrdh")]
                public string SellerPhoneNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置纳税人开户行。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nsrbank")]
                [System.Text.Json.Serialization.JsonPropertyName("nsrbank")]
                public string SellerBank { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置纳税人银行账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nsrbankid")]
                [System.Text.Json.Serialization.JsonPropertyName("nsrbankid")]
                public string SellerBankNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置购货方识别号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ghfnsrsbh")]
                [System.Text.Json.Serialization.JsonPropertyName("ghfnsrsbh")]
                public string? BuyerTaxNumber { get; set; }

                /// <summary>
                /// 获取或设置购货方名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ghfmc")]
                [System.Text.Json.Serialization.JsonPropertyName("ghfmc")]
                public string? BuyerName { get; set; }

                /// <summary>
                /// 获取或设置购货方地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ghfdz")]
                [System.Text.Json.Serialization.JsonPropertyName("ghfdz")]
                public string? BuyerAddress { get; set; }

                /// <summary>
                /// 获取或设置购货方电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ghfdh")]
                [System.Text.Json.Serialization.JsonPropertyName("ghfdh")]
                public string? BuyerPhoneNumber { get; set; }

                /// <summary>
                /// 获取或设置购货方开户行。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ghfbank")]
                [System.Text.Json.Serialization.JsonPropertyName("ghfbank")]
                public string? BuyerBank { get; set; }

                /// <summary>
                /// 获取或设置购货方银行账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ghfbankid")]
                [System.Text.Json.Serialization.JsonPropertyName("ghfbankid")]
                public string? BuyerBankNumber { get; set; }

                /// <summary>
                /// 获取或设置开票人。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("kpr")]
                [System.Text.Json.Serialization.JsonPropertyName("kpr")]
                public string Drawer { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置收款人。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skr")]
                [System.Text.Json.Serialization.JsonPropertyName("skr")]
                public string? Cashier { get; set; }

                /// <summary>
                /// 获取或设置复核人。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fhr")]
                [System.Text.Json.Serialization.JsonPropertyName("fhr")]
                public string? Reviewer { get; set; }

                /// <summary>
                /// 获取或设置价税合计（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("jshj")]
                [System.Text.Json.Serialization.JsonPropertyName("jshj")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public double Fee { get; set; }

                /// <summary>
                /// 获取或设置合计金额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hjje")]
                [System.Text.Json.Serialization.JsonPropertyName("hjje")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public double FeeWithoutTax { get; set; }

                /// <summary>
                /// 获取或设置合计税额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hjse")]
                [System.Text.Json.Serialization.JsonPropertyName("hjse")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public double Tax { get; set; }

                /// <summary>
                /// 获取或设置备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bz")]
                [System.Text.Json.Serialization.JsonPropertyName("bz")]
                public string? Remark { get; set; }

                /// <summary>
                /// 获取或设置行业类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hylx")]
                [System.Text.Json.Serialization.JsonPropertyName("hylx")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int? Type { get; set; }

                /// <summary>
                /// 获取或设置发票行项目数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invoicedetail_list")]
                [System.Text.Json.Serialization.JsonPropertyName("invoicedetail_list")]
                public IList<Types.InvoiceItem> InvoiceItemList { get; set; } = new List<Types.InvoiceItem>();
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
