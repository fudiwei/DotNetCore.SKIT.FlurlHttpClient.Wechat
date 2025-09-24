using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /new-tax-control-fapiao/fapiao-applications/real-estate-leasing 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreateNewTaxControlFapiaoApplicationRealEstateLeasingRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Buyer : CreateNewTaxControlFapiaoApplicationIssueGeneralRequest.Types.Buyer
            {
            }

            public class FapiaoInfo
            {
                public static class Types
                {
                    public class Item : CreateNewTaxControlFapiaoApplicationIssueGeneralRequest.Types.FapiaoInfo.Types.Item
                    {
                        public static class Types
                        {
                            public class RealEstateLeasingInformation
                            {
                                /// <summary>
                                /// 获取或设置省份。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("province")]
                                [System.Text.Json.Serialization.JsonPropertyName("province")]
                                public string? Province { get; set; }

                                /// <summary>
                                /// 获取或设置城市。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("city")]
                                [System.Text.Json.Serialization.JsonPropertyName("city")]
                                public string? City { get; set; }

                                /// <summary>
                                /// 获取或设置详细地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("address")]
                                [System.Text.Json.Serialization.JsonPropertyName("address")]
                                public string Address { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置是否跨市。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("cross_city_flag")]
                                [System.Text.Json.Serialization.JsonPropertyName("cross_city_flag")]
                                public bool IsCrossCity { get; set; }

                                /// <summary>
                                /// 获取或设置租赁起始日期。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("lease_period_start")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("lease_period_start")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                                public DateTimeOffset LeasePeriodStartDate { get; set; }

                                /// <summary>
                                /// 获取或设置租赁截止日期。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("lease_period_end")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("lease_period_end")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                                public DateTimeOffset LeasePeriodEndDate { get; set; }

                                /// <summary>
                                /// 获取或设置产权证或不动产权证号（需使用平台公钥/证书加密）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("certificate_no")]
                                [System.Text.Json.Serialization.JsonPropertyName("certificate_no")]
                                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                                public string? CertificateNumber { get; set; }

                                /// <summary>
                                /// 获取或设置车牌号列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("plate_no")]
                                [System.Text.Json.Serialization.JsonPropertyName("plate_no")]
                                public IList<string>? PlateNumberList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置不动产租赁特定行业额外信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("real_estate_leasing_information")]
                        [System.Text.Json.Serialization.JsonPropertyName("real_estate_leasing_information")]
                        public Types.RealEstateLeasingInformation? RealEstateLeasingInformation { get; set; }
                    }

                    public class Transaction : CreateNewTaxControlFapiaoApplicationIssueGeneralRequest.Types.FapiaoInfo.Types.Transaction
                    {
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
                /// 获取或设置发票行列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("items")]
                [System.Text.Json.Serialization.JsonPropertyName("items")]
                public IList<Types.Item>? ItemList { get; set; }

                /// <summary>
                /// 获取或设置交易信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transaction_information")]
                [System.Text.Json.Serialization.JsonPropertyName("transaction_information")]
                public IList<Types.Transaction>? TransactionList { get; set; }

                /// <summary>
                /// 获取或设置出口业务适用政策代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("export_business_policy_code")]
                [System.Text.Json.Serialization.JsonPropertyName("export_business_policy_code")]
                public int? ExportBusinessPolicyCode { get; set; }

                /// <summary>
                /// 获取或设置增值税即征即退代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("vat_refund_levy_code")]
                [System.Text.Json.Serialization.JsonPropertyName("vat_refund_levy_code")]
                public int? VATRefundLevyCode { get; set; }

                /// <summary>
                /// 获取或设置开票人 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("billing_person_id")]
                [System.Text.Json.Serialization.JsonPropertyName("billing_person_id")]
                public string BillingPersonId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置开票人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("billing_person")]
                [System.Text.Json.Serialization.JsonPropertyName("billing_person")]
                public string? BillingPersonName { get; set; }

                /// <summary>
                /// 获取或设置开具发票类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fapiao_bill_type")]
                [System.Text.Json.Serialization.JsonPropertyName("fapiao_bill_type")]
                public string? FapiaoBillType { get; set; } = string.Empty;

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
        /// 获取或设置购买方信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer_information")]
        [System.Text.Json.Serialization.JsonPropertyName("buyer_information")]
        public Types.Buyer Buyer { get; set; } = new Types.Buyer();

        /// <summary>
        /// 获取或设置电子发票信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fapiao_information")]
        [System.Text.Json.Serialization.JsonPropertyName("fapiao_information")]
        public Types.FapiaoInfo FapiaoInfo { get; set; } = new Types.FapiaoInfo();
    }
}
