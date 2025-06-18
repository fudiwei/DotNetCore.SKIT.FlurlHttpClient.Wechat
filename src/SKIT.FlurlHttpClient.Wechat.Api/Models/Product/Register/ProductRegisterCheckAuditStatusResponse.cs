namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/register/check_audit_status 接口的响应。</para>
    /// </summary>
    public class ProductRegisterCheckAuditStatusResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class PayAuditDetail
                    {
                        /// <summary>
                        /// 获取或设置参数名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("param_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("param_name")]
                        public string ParameterName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置审核驳回原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reject_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                        public string RejectReason { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置注册状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("register_status")]
                [System.Text.Json.Serialization.JsonPropertyName("register_status")]
                public int RegisterStatus { get; set; }

                /// <summary>
                /// 获取或设置商家信息状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_info_status")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_info_status")]
                public int MerchantInfoStatus { get; set; }

                /// <summary>
                /// 获取或设置账户验证状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("acct_verify_status")]
                [System.Text.Json.Serialization.JsonPropertyName("acct_verify_status")]
                public int AccountVerifyStatus { get; set; }

                /// <summary>
                /// 获取或设置基础信息状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("basic_info_status")]
                [System.Text.Json.Serialization.JsonPropertyName("basic_info_status")]
                public int BasicInfoStatus { get; set; }

                /// <summary>
                /// 获取或设置支付签约状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_sign_status")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_sign_status")]
                public int PaySignStatus { get; set; }

                /// <summary>
                /// 获取或设置基础信息驳回原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_reject_reasons")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_reject_reasons")]
                public string? AuditRejectReason { get; set; }

                /// <summary>
                /// 获取或设置支付资质驳回原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_audit_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_audit_detail")]
                public Types.PayAuditDetail? PayAuditDetail { get; set; }

                /// <summary>
                /// 获取或设置法人验证链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_validation_url")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_validation_url")]
                public string? LegalPersonValidationUrl { get; set; }

                /// <summary>
                /// 获取或设置注册 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("registered_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("registered_appid")]
                public string? RegisteredAppId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
