namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/miniapppay/get_applyment_status 接口的响应。</para>
    /// </summary>
    public class CgibinMiniAppPayGetApplymentStatusResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Applyment
            {
                public static class Types
                {
                    public class AuditDetail
                    {
                        /// <summary>
                        /// 获取或设置参数名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("param_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("param_name")]
                        public string ParameterName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置驳回理由。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reject_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                        public string? RejectReason { get; set; }
                    }

                    public class AccountValidation
                    {
                        /// <summary>
                        /// 获取或设置付款户名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("account_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("account_name")]
                        public string AccountName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置付款卡号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("account_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("account_no")]
                        public string AccountNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置收款开户银行。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("destination_account_bank")]
                        [System.Text.Json.Serialization.JsonPropertyName("destination_account_bank")]
                        public string DestinationAccountBank { get; set; } = default!;

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
                        /// 获取或设置付款金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
                        public int PayAmount { get; set; }

                        /// <summary>
                        /// 获取或设置备注信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("remark")]
                        [System.Text.Json.Serialization.JsonPropertyName("remark")]
                        public string Remark { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置汇款截止时间字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("deadline")]
                        [System.Text.Json.Serialization.JsonPropertyName("deadline")]
                        public string DeadlineString { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置申请状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("applyment_state")]
                [System.Text.Json.Serialization.JsonPropertyName("applyment_state")]
                public string ApplymentState { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请状态描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("applyment_state_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("applyment_state_desc")]
                public string ApplymentStateDescription { get; set; } = default!;

                /// <summary>
                /// 获取或设置签约状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sign_state")]
                [System.Text.Json.Serialization.JsonPropertyName("sign_state")]
                public string SignState { get; set; } = default!;

                /// <summary>
                /// 获取或设置签约链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sign_url")]
                [System.Text.Json.Serialization.JsonPropertyName("sign_url")]
                public string? SignUrl { get; set; }

                /// <summary>
                /// 获取或设置驳回原因详细信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_detail")]
                public Types.AuditDetail[]? AuditDetailList { get; set; }

                /// <summary>
                /// 获取或设置汇款账户验证信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_validation")]
                [System.Text.Json.Serialization.JsonPropertyName("account_validation")]
                public Types.AccountValidation? AccountValidation { get; set; }

                /// <summary>
                /// 获取或设置电商平台二级商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
                public string? SubMerchantId { get; set; }

                /// <summary>
                /// 获取或设置法人验证链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_validation_url")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_validation_url")]
                public string? LegalPersonValidationUrl { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置申请单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public Types.Applyment Applyment { get; set; } = default!;

        /// <summary>
        /// 获取或设置申请单当前所处阶段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_state")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_state")]
        public int ApplyState { get; set; }

        /// <summary>
        /// 获取或设置当前签约阶段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("real_sign_state")]
        [System.Text.Json.Serialization.JsonPropertyName("real_sign_state")]
        public int RealSignState { get; set; }

        /// <summary>
        /// 获取或设置驳回理由。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reject_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
        public string? RejectReason { get; set; }
    }
}
