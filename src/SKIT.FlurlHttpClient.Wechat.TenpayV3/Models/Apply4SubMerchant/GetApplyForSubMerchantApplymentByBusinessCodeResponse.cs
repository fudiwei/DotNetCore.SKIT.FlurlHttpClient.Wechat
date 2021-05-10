using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /applyment4sub/applyment/business_code/{business_code} 接口的响应。</para>
    /// </summary>
    public class GetApplyForSubMerchantApplymentByBusinessCodeResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class AuditDetail
            {
                /// <summary>
                /// 获取或设置字段名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("field")]
                [System.Text.Json.Serialization.JsonPropertyName("field")]
                public string Field { get; set; } = default!;

                /// <summary>
                /// 获取或设置字段名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("field_name")]
                [System.Text.Json.Serialization.JsonPropertyName("field_name")]
                public string FieldName { get; set; } = default!;

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
        [Newtonsoft.Json.JsonProperty("business_code")]
        [System.Text.Json.Serialization.JsonPropertyName("business_code")]
        public string BusinessCode { get; set; } = default!;

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
        [Newtonsoft.Json.JsonProperty("applyment_state_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("applyment_state_msg")]
        public string ApplymentStateMessage { get; set; } = default!;

        /// <summary>
        /// 获取或设置特约商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置超级管理员签约链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_url")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_url")]
        public string? SignUrl { get; set; }

        /// <summary>
        /// 获取或设置驳回原因详情列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_detail")]
        public Types.AuditDetail[]? AuditList { get; set; }
    }
}
