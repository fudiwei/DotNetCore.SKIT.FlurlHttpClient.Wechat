using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /rate-activity/applications/id/{application_id} 接口的响应。</para>
    /// </summary>
    public class GetRateActivityApplicationByApplicationIdResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置申请单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("application_state")]
        [System.Text.Json.Serialization.JsonPropertyName("application_state")]
        public string ApplicationState { get; set; } = default!;

        /// <summary>
        /// 获取或设置从业机构特约商户号	。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置驳回参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reject_parameter")]
        [System.Text.Json.Serialization.JsonPropertyName("reject_parameter")]
        public string? RejectParameter { get; set; }

        /// <summary>
        /// 获取或设置驳回原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reject_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
        public string? RejectReason { get; set; }

        /// <summary>
        /// 获取或设置审核通过时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pass_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("pass_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? PassTime { get; set; }
    }
}
