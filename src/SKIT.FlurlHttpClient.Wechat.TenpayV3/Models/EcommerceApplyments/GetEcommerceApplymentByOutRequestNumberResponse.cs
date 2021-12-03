using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /ecommerce/applyments/out-request-no/{out_request_no} 接口的响应。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class GetEcommerceApplymentByOutRequestNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class AccountValidation
            {
                /// <summary>
                /// 获取或设置付款户名（需使用商户私钥解密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_name")]
                [System.Text.Json.Serialization.JsonPropertyName("account_name")]
                [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_PKCS8_ECB)]
                public string AccountName { get; set; } = default!;

                /// <summary>
                /// 获取或设置付款卡号（需使用商户私钥解密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_no")]
                [System.Text.Json.Serialization.JsonPropertyName("account_no")]
                [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_PKCS8_ECB)]
                public string? AccountNumber { get; set; }

                /// <summary>
                /// 获取或设置汇款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
                public int PayAmount { get; set; }

                /// <summary>
                /// 获取或设置收款户名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("destination_account_name")]
                [System.Text.Json.Serialization.JsonPropertyName("destination_account_name")]
                public string DestinationAccountName { get; set; } = default!;

                /// <summary>
                /// 获取或设置收款卡号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("destination_account_number")]
                [System.Text.Json.Serialization.JsonPropertyName("destination_account_number")]
                public string DestinationAccountNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置收款开户银行。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("destination_account_bank")]
                [System.Text.Json.Serialization.JsonPropertyName("destination_account_bank")]
                public string DestinationAccountBank { get; set; } = default!;

                /// <summary>
                /// 获取或设置收款省市信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                public string DestinationAccountCity { get; set; } = default!;

                /// <summary>
                /// 获取或设置备注信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string Remark { get; set; } = default!;

                /// <summary>
                /// 获取或设置汇款截止时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deadline")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("deadline")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                public DateTimeOffset Deadline { get; set; }
            }

            public class AuditDetail
            {
                /// <summary>
                /// 获取或设置参数名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("param_name")]
                [System.Text.Json.Serialization.JsonPropertyName("param_name")]
                public string ParameterName { get; set; } = default!;

                /// <summary>
                /// 获取或设置驳回原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reject_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                public string RejectReason { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置业务申请编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置申请单编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applyment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("applyment_id")]
        public long ApplymentId { get; set; }

        /// <summary>
        /// 获取或设置申请单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applyment_state")]
        [System.Text.Json.Serialization.JsonPropertyName("applyment_state")]
        public string ApplymentState { get; set; } = default!;

        /// <summary>
        /// 获取或设置申请单状态描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applyment_state_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("applyment_state_desc")]
        public string ApplymentStateDescription { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置签约状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_state")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_state")]
        public string? SignState { get; set; }

        /// <summary>
        /// 获取或设置超级管理员签约链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_url")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_url")]
        public string? SignUrl { get; set; }

        /// <summary>
        /// 获取或设置汇款账户验证信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_validation")]
        [System.Text.Json.Serialization.JsonPropertyName("account_validation")]
        public Types.AccountValidation? AccountValidation { get; set; }

        /// <summary>
        /// 获取或设置法人验证链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("legal_validation_url")]
        [System.Text.Json.Serialization.JsonPropertyName("legal_validation_url")]
        public string? LegalPersonValidationUrl { get; set; }

        /// <summary>
        /// 获取或设置驳回原因详情列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_detail")]
        public Types.AuditDetail[]? AuditList { get; set; }
    }
}
