using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /taxi-invoice/cards 接口的请求。</para>
    /// </summary>
    public class CreateTaxiInvoiceCardRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class InvoiceCard
            {
                public static class Types
                {
                    public class Buyer
                    {
                        /// <summary>
                        /// 获取或设置购买方类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置购买方名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置纳税人识别号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("taxpayer_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("taxpayer_id")]
                        public string? TaxpayerId { get; set; }

                        /// <summary>
                        /// 获取或设置地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public string? Address { get; set; }

                        /// <summary>
                        /// 获取或设置电话。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("telephone")]
                        [System.Text.Json.Serialization.JsonPropertyName("telephone")]
                        public string? PhoneNumber { get; set; }

                        /// <summary>
                        /// 获取或设置开户银行。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bank_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
                        public string? BankName { get; set; }

                        /// <summary>
                        /// 获取或设置银行账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bank_account")]
                        [System.Text.Json.Serialization.JsonPropertyName("bank_account")]
                        public string? BankAccountNumber { get; set; }
                    }

                    public class Seller
                    {
                        /// <summary>
                        /// 获取或设置销售方名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置纳税人识别号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("taxpayer_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("taxpayer_id")]
                        public string TaxpayerId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public string? Address { get; set; }

                        /// <summary>
                        /// 获取或设置电话。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("telephone")]
                        [System.Text.Json.Serialization.JsonPropertyName("telephone")]
                        public string? PhoneNumber { get; set; }

                        /// <summary>
                        /// 获取或设置开户银行。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bank_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
                        public string? BankName { get; set; }

                        /// <summary>
                        /// 获取或设置银行账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bank_account")]
                        [System.Text.Json.Serialization.JsonPropertyName("bank_account")]
                        public string? BankAccountNumber { get; set; }
                    }

                    public class Extra
                    {
                        /// <summary>
                        /// 获取或设置收款人。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("payee")]
                        [System.Text.Json.Serialization.JsonPropertyName("payee")]
                        public string? Payee { get; set; }

                        /// <summary>
                        /// 获取或设置复核人。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reviewer")]
                        [System.Text.Json.Serialization.JsonPropertyName("reviewer")]
                        public string? Reviewer { get; set; }

                        /// <summary>
                        /// 获取或设置开票人。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("drawer")]
                        [System.Text.Json.Serialization.JsonPropertyName("drawer")]
                        public string Drawer { get; set; } = string.Empty;
                    }

                    public class Item
                    {
                        /// <summary>
                        /// 获取或设置货物或应税劳务或服务编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tax_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("tax_code")]
                        public string TaxCode { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置货物或应税劳务或服务名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_name")]
                        public string GoodsName { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置规格型号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("specification")]
                        [System.Text.Json.Serialization.JsonPropertyName("specification")]
                        public string? Specification { get; set; }

                        /// <summary>
                        /// 获取或设置单位。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unit")]
                        [System.Text.Json.Serialization.JsonPropertyName("unit")]
                        public string? Unit { get; set; }

                        /// <summary>
                        /// 获取或设置数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("quantity")]
                        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                        public int Quantity { get; set; }

                        /// <summary>
                        /// 获取或设置单价（单位：10^-6分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unit_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("unit_price")]
                        public long UnitPrice { get; set; }

                        /// <summary>
                        /// 获取或设置单行金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public int Amount { get; set; }

                        /// <summary>
                        /// 获取或设置单行税额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tax_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("tax_amount")]
                        public int TaxAmount { get; set; }

                        /// <summary>
                        /// 获取或设置单行合计（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                        public int TotalAmount { get; set; }

                        /// <summary>
                        /// 获取或设置税率（单位：万分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tax_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("tax_rate")]
                        public int TaxRate { get; set; }

                        /// <summary>
                        /// 获取或设置税收优惠政策标识。
                        /// <para>默认值：NO_FAVORABLE</para>
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tax_prefer_mark")]
                        [System.Text.Json.Serialization.JsonPropertyName("tax_prefer_mark")]
                        public string TaxPreferMark { get; set; } = "NO_FAVORABLE";

                        /// <summary>
                        /// 获取或设置是否是折扣行。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount")]
                        public bool IsDiscount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置发票文件 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fapiao_media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("fapiao_media_id")]
                public string InvoiceMediaId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置发票号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fapiao_number")]
                [System.Text.Json.Serialization.JsonPropertyName("fapiao_number")]
                public string InvoiceNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置发票代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fapiao_code")]
                [System.Text.Json.Serialization.JsonPropertyName("fapiao_code")]
                public string InvoiceCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置开票时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fapiao_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("fapiao_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset InvoiceTime { get; set; }

                /// <summary>
                /// 获取或设置校验码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("check_code")]
                [System.Text.Json.Serialization.JsonPropertyName("check_code")]
                public string CheckCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置密码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("password")]
                [System.Text.Json.Serialization.JsonPropertyName("password")]
                public string Password { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置总价税合计（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                public int TotalAmount { get; set; }

                /// <summary>
                /// 获取或设置总税额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tax_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("tax_amount")]
                public int TaxAmount { get; set; }

                /// <summary>
                /// 获取或设置总金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置购买方信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("buyer_information")]
                [System.Text.Json.Serialization.JsonPropertyName("buyer_information")]
                public Types.Buyer Buyer { get; set; } = new Types.Buyer();

                /// <summary>
                /// 获取或设置销售方信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("seller_information")]
                [System.Text.Json.Serialization.JsonPropertyName("seller_information")]
                public Types.Seller Seller { get; set; } = new Types.Seller();

                /// <summary>
                /// 获取或设置额外信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("extra_information")]
                [System.Text.Json.Serialization.JsonPropertyName("extra_information")]
                public Types.Extra Extra { get; set; } = new Types.Extra();

                /// <summary>
                /// 获取或设置发票行列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("items")]
                [System.Text.Json.Serialization.JsonPropertyName("items")]
                public IList<Types.Item>? ItemList { get; set; }

                /// <summary>
                /// 获取或设置备注信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string? Remark { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置获取乘客行程单详情的凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("token")]
        [System.Text.Json.Serialization.JsonPropertyName("token")]
        public string Token { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置公司商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("company_mchid")]
        public string CompanyMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置行政区划代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("region_id")]
        [System.Text.Json.Serialization.JsonPropertyName("region_id")]
        public int RegionId { get; set; }

        /// <summary>
        /// 获取或设置发票卡券信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fapiao_card_information")]
        [System.Text.Json.Serialization.JsonPropertyName("fapiao_card_information")]
        public Types.InvoiceCard InvoiceCard { get; set; } = new Types.InvoiceCard();
    }
}
