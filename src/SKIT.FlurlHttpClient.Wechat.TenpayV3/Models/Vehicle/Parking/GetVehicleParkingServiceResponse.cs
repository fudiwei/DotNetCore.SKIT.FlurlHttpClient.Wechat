using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /vehicle/parking/services/find 接口的响应。</para>
    /// </summary>
    public class GetVehicleParkingServiceResponse : WechatTenpayResponse
    {
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
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置服务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_state")]
        [System.Text.Json.Serialization.JsonPropertyName("service_state")]
        public string ServiceState { get; set; } = default!;

        /// <summary>
        /// 获取或设置服务开通时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_open_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("service_open_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? ServiceOpenTime { get; set; }
    }
}
