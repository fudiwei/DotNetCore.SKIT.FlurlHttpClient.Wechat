using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /new-tax-control-fapiao/fapiao-applications/{fapiao_apply_id} 接口的响应。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class GetNewTaxControlFapiaoApplicationByFapiaoApplyIdResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Fapiao
            {
                public static class Types
                {
                    public class FapiaoDetail
                    {
                        /// <summary>
                        /// 获取或设置发票代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fapiao_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("fapiao_code")]
                        public string FapiaoCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置发票号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fapiao_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("fapiao_number")]
                        public string FapiaoNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置校验码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("check_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("check_code")]
                        public string CheckCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置密码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("password")]
                        [System.Text.Json.Serialization.JsonPropertyName("password")]
                        public string Password { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置开票时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fapiao_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("fapiao_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                        public DateTimeOffset FapiaoTime { get; set; }
                    }

                    public class FapiaoCard
                    {
                        /// <summary>
                        /// 获取或设置微信 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("card_appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("card_appid")]
                        public string AppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户唯一标识。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("card_openid")]
                        [System.Text.Json.Serialization.JsonPropertyName("card_openid")]
                        public string OpenId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置电子发票卡券模板 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("card_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
                        public string? CardTemplateId { get; set; }

                        /// <summary>
                        /// 获取或设置电子发票在卡包中的编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("card_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("card_code")]
                        public string? CardCode { get; set; }

                        /// <summary>
                        /// 获取或设置发票卡券状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("card_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("card_status")]
                        public string? CardStatus { get; set; }
                    }

                    public class Buyer
                    {
                        /// <summary>
                        /// 获取或设置购买方类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置购买方名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

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

                        /// <summary>
                        /// 获取或设置用户手机号码（需使用商户私钥解密）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("phone")]
                        [System.Text.Json.Serialization.JsonPropertyName("phone")]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                        public string? UserMobileNumber { get; set; }

                        /// <summary>
                        /// 获取或设置用户邮箱地址（需使用商户私钥解密）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("email")]
                        [System.Text.Json.Serialization.JsonPropertyName("email")]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                        public string? UserEmail { get; set; }

                        /// <summary>
                        /// 获取或设置订单金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public int? Amount { get; set; }

                        /// <summary>
                        /// 获取或设置商户订单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_trade_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
                        public string? OutTradeNumber { get; set; }

                        /// <summary>
                        /// 获取或设置开具发票类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fapiao_bill_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("fapiao_bill_type")]
                        public string? FapiaoBillType { get; set; }

                        /// <summary>
                        /// 获取或设置用户留言信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_apply_message")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_apply_message")]
                        public string? UserApplyMessage { get; set; }
                    }

                    public class Seller : GetNewTaxControlFapiaoMerchantBaseInformationResponse.Types.Seller
                    {
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
                        public string Drawer { get; set; } = default!;
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
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tax_prefer_mark")]
                        [System.Text.Json.Serialization.JsonPropertyName("tax_prefer_mark")]
                        public string? TaxPreferMark { get; set; }

                        /// <summary>
                        /// 获取或设置是否是折扣行。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount")]
                        public bool IsDiscount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商户发票单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fapiao_id")]
                [System.Text.Json.Serialization.JsonPropertyName("fapiao_id")]
                public string FapiaoId { get; set; } = default!;

                /// <summary>
                /// 获取或设置发票状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string FapiaoStatus { get; set; } = default!;

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
                /// 获取或设置蓝字发票信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("blue_fapiao")]
                [System.Text.Json.Serialization.JsonPropertyName("blue_fapiao")]
                public Types.FapiaoDetail? BlueFapiao { get; set; }

                /// <summary>
                /// 获取或设置红字发票信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("red_fapiao")]
                [System.Text.Json.Serialization.JsonPropertyName("red_fapiao")]
                public Types.FapiaoDetail? RedFapiao { get; set; }

                /// <summary>
                /// 获取或设置电子发票卡券信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_information")]
                [System.Text.Json.Serialization.JsonPropertyName("card_information")]
                public Types.FapiaoCard? FapiaoCard { get; set; }

                /// <summary>
                /// 获取或设置购买方信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("buyer_information")]
                [System.Text.Json.Serialization.JsonPropertyName("buyer_information")]
                public Types.Buyer Buyer { get; set; } = default!;

                /// <summary>
                /// 获取或设置销售方信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("seller_information")]
                [System.Text.Json.Serialization.JsonPropertyName("seller_information")]
                public Types.Seller Seller { get; set; } = default!;

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
                public Types.Item[]? ItemList { get; set; }

                /// <summary>
                /// 获取或设置备注信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string? Remark { get; set; }

                /// <summary>
                /// 获取或设置开票失败错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fapiao_error_code")]
                [System.Text.Json.Serialization.JsonPropertyName("fapiao_error_code")]
                public string? FapiaoErrorCode { get; set; }

                /// <summary>
                /// 获取或设置开票失败错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fapiao_error_message")]
                [System.Text.Json.Serialization.JsonPropertyName("fapiao_error_message")]
                public string? FapiaoErrorMessage { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置发票信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fapiao_information")]
        [System.Text.Json.Serialization.JsonPropertyName("fapiao_information")]
        public Types.Fapiao[] FapiaoList { get; set; } = default!;

        /// <summary>
        /// 获取或设置发票数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
