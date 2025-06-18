namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /mchalterapply/mchsubjectalterapplyment/merchant/{merchant_code}/out-request-no/{out_request_no} 接口的响应。</para>
    /// </summary>
    public class GetMerchantAlterApplyMerchantSubjectAlterApplymentByOutRequestNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class AuditRejectDetail
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
        /// 获取或设置特约商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_code")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_code")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置业务申请编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_id")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_id")]
        public string ApplymentId { get; set; } = default!;

        /// <summary>
        /// 获取或设置申请单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string ApplymentState { get; set; } = default!;

        /// <summary>
        /// 获取或设置驳回原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_reject_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_reject_reason")]
        public string? AuditRejectReason { get; set; }

        /// <summary>
        /// 获取或设置驳回原因详情列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_reject_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_reject_detail")]
        public Types.AuditRejectDetail[]? AuditRejectDetailList { get; set; }
    }
}
