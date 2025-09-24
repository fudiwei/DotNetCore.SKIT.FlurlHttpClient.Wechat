using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /mch-operation-manage/enhanced-due-diligence/{due_diligence_id}/submit 接口的响应。</para>
    /// </summary>
    public class CreateMerchantOperationManageEnhancedDueDiligenceSubmitResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置尽调单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("due_diligence_state")]
        [System.Text.Json.Serialization.JsonPropertyName("due_diligence_state")]
        public string DueDiligenceState { get; set; } = default!;

        /// <summary>
        /// 获取或设置提交时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("submit_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("submit_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? SubmitTime { get; set; }

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
