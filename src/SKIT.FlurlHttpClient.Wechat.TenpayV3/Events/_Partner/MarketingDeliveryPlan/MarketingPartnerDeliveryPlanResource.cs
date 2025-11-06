using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 DELIVERY_PLAN.CHANGE （仅限服务商）通知的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4016168699 ]]>
    /// </para>
    /// </summary>
    public class MarketingPartnerDeliveryPlanResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        /// <summary>
        /// 获取或设置投放计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_id")]
        public string PlanId { get; set; } = default!;

        /// <summary>
        /// 获取或设置投放计划状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_state")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_state")]
        public string PlanState { get; set; } = default!;

        /// <summary>
        /// 获取或设置审核状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_state")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_state")]
        public string? AuditState { get; set; }

        /// <summary>
        /// 获取或设置变更原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("change_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("change_reason")]
        public string? ChangeReason { get; set; }

        /// <summary>
        /// 获取或设置修改时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("modify_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("modify_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset ModifyTime { get; set; }
    }
}
