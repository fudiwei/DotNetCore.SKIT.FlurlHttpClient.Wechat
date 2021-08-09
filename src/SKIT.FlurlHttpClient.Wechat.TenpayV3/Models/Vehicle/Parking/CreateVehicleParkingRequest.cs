using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /vehicle/parking/parkings 接口的请求。</para>
    /// </summary>
    public class CreateVehicleParkingRequest : WechatTenpayRequest
    {
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
        public string OutParkingNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置车牌号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plate_number")]
        [System.Text.Json.Serialization.JsonPropertyName("plate_number")]
        public string PlateNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置车牌颜色。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plate_color")]
        [System.Text.Json.Serialization.JsonPropertyName("plate_color")]
        public string PlateColor { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

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
        public string ParkingName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置免费时长（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("free_duration")]
        [System.Text.Json.Serialization.JsonPropertyName("free_duration")]
        public int FreeDuration { get; set; }
    }
}
