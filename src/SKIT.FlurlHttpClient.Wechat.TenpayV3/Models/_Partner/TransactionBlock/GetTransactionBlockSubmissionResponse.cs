using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /transaction-block/transaction-block-submissions/{block_submission_id} 接口的响应。</para>
    /// </summary>
    public class GetTransactionBlockSubmissionResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置交易拦截申诉 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("block_submission_id")]
        [System.Text.Json.Serialization.JsonPropertyName("block_submission_id")]
        public string BlockSubmissionId { get; set; } = default!;

        /// <summary>
        /// 获取或设置提交时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("submit_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("submit_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset SubmitTime { get; set; }

        /// <summary>
        /// 获取或设置审核结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("review_result")]
        [System.Text.Json.Serialization.JsonPropertyName("review_result")]
        public string? ReviewResult { get; set; }

        /// <summary>
        /// 获取或设置审核时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("review_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("review_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? ReviewTime { get; set; }

        /// <summary>
        /// 获取或设置审核驳回原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("review_reject_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("review_reject_reason")]
        public string? ReviewRejectReason { get; set; }
    }
}
