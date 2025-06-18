using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Events
{
    /// <summary>
    /// <para>表示车主平台通知的模型。</para>
    /// </summary>
    public class VehicleEvent : WechatTenpayEvent
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mch_id")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置车牌号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plate_number")]
        [System.Text.Json.Serialization.JsonPropertyName("plate_number")]
        public string PlateNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置发起扣费方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deduct_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("deduct_mode")]
        public string? DeductMode { get; set; }

        /// <summary>
        /// 获取或设置变更事件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vehicle_event_type")]
        [System.Text.Json.Serialization.JsonPropertyName("vehicle_event_type")]
        public string EventType { get; set; } = default!;

        /// <summary>
        /// 获取或设置变更事件信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vehicle_event_des")]
        [System.Text.Json.Serialization.JsonPropertyName("vehicle_event_des")]
        public string? EventDescription { get; set; }

        /// <summary>
        /// 获取或设置变更事件时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vehicle_event_createtime")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.DigitalDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("vehicle_event_createtime")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.DigitalDateTimeOffsetConverter))]
        public DateTimeOffset EventTime { get; set; }
    }
}
