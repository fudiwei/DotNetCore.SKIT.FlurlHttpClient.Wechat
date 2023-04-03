using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 VEHICLE.ENTRANCE_STATE_CHANGE 通知的数据。</para>
    /// </summary>
    public class VehicleEntranceStateChangeResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置商户入场 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_parking_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_parking_no")]
        public string OutParkingId { get; set; } = default!;

        /// <summary>
        /// 获取或设置停车入场 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parking_id")]
        [System.Text.Json.Serialization.JsonPropertyName("parking_id")]
        public string ParkingId { get; set; } = default!;

        /// <summary>
        /// 获取或设置车牌号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plate_number")]
        [System.Text.Json.Serialization.JsonPropertyName("plate_number")]
        public string PlateNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置车牌颜色。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plate_color")]
        [System.Text.Json.Serialization.JsonPropertyName("plate_color")]
        public string PlateColor { get; set; } = default!;

        /// <summary>
        /// 获取或设置入场时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// 获取或设置停车场名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parking_name")]
        [System.Text.Json.Serialization.JsonPropertyName("parking_name")]
        public string ParkingName { get; set; } = default!;

        /// <summary>
        /// 获取或设置免费时长（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("free_duration")]
        [System.Text.Json.Serialization.JsonPropertyName("free_duration")]
        public int FreeDuration { get; set; }

        /// <summary>
        /// 获取或设置停车入场状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parking_state")]
        [System.Text.Json.Serialization.JsonPropertyName("parking_state")]
        public string ParkingState { get; set; } = default!;

        /// <summary>
        /// 获取或设置不可用原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("blocked_state_description")]
        [System.Text.Json.Serialization.JsonPropertyName("blocked_state_description")]
        public string? BlockReason { get; set; }

        /// <summary>
        /// 获取或设置状态变更时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state_update_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("state_update_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset ParkingStateUpdateTime { get; set; }
    }
}
