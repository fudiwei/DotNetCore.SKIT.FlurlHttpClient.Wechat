using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /new-tax-control-fapiao/fapiao-applications 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreateNewTaxControlFapiaoApplicationRequest : WechatTenpayRequest
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

                /// <summary>
                /// 获取或设置用户手机号码（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone")]
                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string? UserMobileNumber { get; set; }

                /// <summary>
                /// 获取或设置用户邮箱地址（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("email")]
                [System.Text.Json.Serialization.JsonPropertyName("email")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string? UserEmail { get; set; }
            }

            public class Fapiao
            {
                public static class Types
                {
                    public class Item
                    {
                        /// <summary>
                        /// 获取或设置货物或应税劳务或服务编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tax_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("tax_code")]
                        public string TaxCode { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置货物或应税劳务或服务分类。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_category")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_category")]
                        public string? GoodsCategory { get; set; }

                        /// <summary>
                        /// 获取或设置货物或应税劳务或服务名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_name")]
                        public string? GoodsName { get; set; }

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
                        public int? TaxRate { get; set; }

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
                public string FapiaoId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置总价税合计（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                public int TotalAmount { get; set; }

                /// <summary>
                /// 获取或设置是否以清单形式开具发票。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("need_list")]
                [System.Text.Json.Serialization.JsonPropertyName("need_list")]
                public bool RequireItemList { get; set; }

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
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置发票申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fapiao_apply_id")]
        [System.Text.Json.Serialization.JsonPropertyName("fapiao_apply_id")]
        public string FapiaoApplyId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开票场景。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        [System.Text.Json.Serialization.JsonPropertyName("scene")]
        public string Scene { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置购买方信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer_information")]
        [System.Text.Json.Serialization.JsonPropertyName("buyer_information")]
        public Types.Buyer Buyer { get; set; } = new Types.Buyer();

        /// <summary>
        /// 获取或设置电子发票信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fapiao_information")]
        [System.Text.Json.Serialization.JsonPropertyName("fapiao_information")]
        public IList<Types.Fapiao> FapiaoList { get; set; } = new List<Types.Fapiao>();
    }
}
