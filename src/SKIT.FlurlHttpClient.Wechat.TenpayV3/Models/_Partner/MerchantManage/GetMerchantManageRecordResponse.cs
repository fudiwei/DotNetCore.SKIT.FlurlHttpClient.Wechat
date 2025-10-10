using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /mch-manage/mch-manage-records/{manage_record_id} 接口的响应。</para>
    /// </summary>
    public class GetMerchantManageRecordResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户管理记录 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("manage_record_id")]
        [System.Text.Json.Serialization.JsonPropertyName("manage_record_id")]
        public string ManageRecordId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户管理记录类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("manage_record_type")]
        [System.Text.Json.Serialization.JsonPropertyName("manage_record_type")]
        public string ManageRecordType { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户管理记录状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("manage_record_state")]
        [System.Text.Json.Serialization.JsonPropertyName("manage_record_state")]
        public string ManageRecordState { get; set; } = default!;

        /// <summary>
        /// 获取或设置管控时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("manage_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("manage_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset ManageTime { get; set; }

        /// <summary>
        /// 获取或设置管控原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("manage_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("manage_reason")]
        public string ManageReason { get; set; } = default!;

        /// <summary>
        /// 获取或设置限制功能。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit_ability")]
        [System.Text.Json.Serialization.JsonPropertyName("limit_ability")]
        public string? LimitAbility { get; set; }

        /// <summary>
        /// 获取或设置解除管控方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recover_way")]
        [System.Text.Json.Serialization.JsonPropertyName("recover_way")]
        public string? RecoverWay { get; set; }

        /// <summary>
        /// 获取或设置是否允许提交资料。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_submit")]
        [System.Text.Json.Serialization.JsonPropertyName("allow_submit")]
        public bool IsAllowSubmit { get; set; }

        /// <summary>
        /// 获取或设置禁止提交资料原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("forbid_submit_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("forbid_submit_reason")]
        public string? ForbidSubmitReason { get; set; }

        /// <summary>
        /// 获取或设置可提交资料开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("submit_start_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("submit_start_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? SubmitStartTime { get; set; }

        /// <summary>
        /// 获取或设置可提交资料结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("submit_end_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("submit_end_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? SubmitEndTime { get; set; }

        /// <summary>
        /// 获取或设置要求提交的资料（JSON 格式）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requested_item_info")]
        [System.Text.Json.Serialization.JsonPropertyName("requested_item_info")]
        public string? RequestedData { get; set; }

        /// <summary>
        /// 获取或设置解除管控原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recover_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("recover_reason")]
        public string? RecoverReason { get; set; }

        /// <summary>
        /// 获取或设置解除管控时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recover_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("recover_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? RecoverTime { get; set; }

        /// <summary>
        /// 获取或设置申诉驳回原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reject_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
        public string? RejectReason { get; set; }

        /// <summary>
        /// 获取或设置审核时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("approve_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("approve_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? ApproveTime { get; set; }
    }
}
