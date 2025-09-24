using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /mch-operation-manage/enhanced-due-diligence/{due_diligence_id} 接口的响应。</para>
    /// </summary>
    public class GetMerchantOperationManageEnhancedDueDiligenceByDueDiligenceIdResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置尽调单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("due_diligence_id")]
        [System.Text.Json.Serialization.JsonPropertyName("due_diligence_id")]
        public string DueDiligenceId { get; set; } = default!;

        /// <summary>
        /// 获取或设置尽调单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("due_diligence_state")]
        [System.Text.Json.Serialization.JsonPropertyName("due_diligence_state")]
        public string DueDiligenceState { get; set; } = default!;

        /// <summary>
        /// 获取或设置截止时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deadline_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("deadline_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset DeadlineTime { get; set; }

        /// <summary>
        /// 获取或设置提交时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("submit_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("submit_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? SubmitTime { get; set; }

        /// <summary>
        /// 获取或设置终止时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("terminal_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("terminal_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? TerminalTime { get; set; }

        /// <summary>
        /// 获取或设置驳回时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reject_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("reject_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? RejectTime { get; set; }

        /// <summary>
        /// 获取或设置驳回原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reject_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
        public string? RejectReason { get; set; }

        /// <summary>
        /// 获取或设置完成时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complete_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("complete_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? CompleteTime { get; set; }

        /// <summary>
        /// 获取或设置要求提交的资料。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("submission_template")]
        [System.Text.Json.Serialization.JsonPropertyName("submission_template")]
        public string SubmissionTemplateJson { get; set; } = default!;

        /// <summary>
        /// 获取或设置已提交的资料 JSON 内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("submission_data")]
        [System.Text.Json.Serialization.JsonPropertyName("submission_data")]
        public string? SubmissionDataJson { get; set; }
    }
}
