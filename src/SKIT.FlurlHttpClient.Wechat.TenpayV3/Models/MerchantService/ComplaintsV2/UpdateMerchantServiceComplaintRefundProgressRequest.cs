using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant-service/complaints-v2/{complaint_id}/update-refund-progress 接口的请求。</para>
    /// </summary>
    public class UpdateMerchantServiceComplaintRefundProgressRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置投诉单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComplaintId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置审批动作。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置预计发起退款天数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("launch_refund_day")]
        [System.Text.Json.Serialization.JsonPropertyName("launch_refund_day")]
        public int? LaunchRefundDays { get; set; }

        /// <summary>
        /// 获取或设置拒绝退款原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reject_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
        public string? RejectReason { get; set; }

        /// <summary>
        /// 获取或设置拒绝退款的举证图片 MediaId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reject_media_list")]
        [System.Text.Json.Serialization.JsonPropertyName("reject_media_list")]
        public IList<string>? RejectMediaIdList { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }
    }
}
