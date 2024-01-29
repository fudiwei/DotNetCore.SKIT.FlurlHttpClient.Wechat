using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /ecommerce/account/cancel-applications/out-apply-no/{out_apply_no} 接口的响应。</para>
    /// </summary>
    public class GetEcommerceAccountCancelApplicationByOutApplyNumberResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户注销申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_apply_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_apply_no")]
        public string OutApplyNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置注销状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_state")]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_state")]
        public string CancelState { get; set; } = default!;

        /// <summary>
        /// 获取或设置驳回原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reject_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
        public string? RejectReason { get; set; }

        /// <summary>
        /// 获取或设置更新时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? UpdateTime { get; set; }
    }
}
