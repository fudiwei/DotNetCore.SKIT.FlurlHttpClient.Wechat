using System;
using System.Globalization;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /taxi-invoice/attendance/punch 接口的请求。</para>
    /// </summary>
    public class CreateTaxiInvoicePunchAttendanceRequest : WechatTenpayRequest
    {
        internal static class Converters
        {
            internal class RequestPropertyEventTimeNewtonsoftJsonConverter : Newtonsoft.Json.Converters.Common.FormattedDateTimeOffsetConverterBase
            {
                internal const string DATETIME_FORMAT = "yyyy-MM-dd'T'HH:mm:ss.fffzzz";

                protected override string FormatString { get { return DATETIME_FORMAT; } }
            }

            internal class RequestPropertyEventTimeSystemTextJsonConverter : System.Text.Json.Serialization.Common.FormattedDateTimeOffsetConverterBase
            {
                internal const string DATETIME_FORMAT = "yyyy-MM-dd'T'HH:mm:ss.fffzzz";

                protected override string FormatString { get { return DATETIME_FORMAT; } }
            }
        }

        /// <summary>
        /// 获取或设置车牌号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plate_number")]
        [System.Text.Json.Serialization.JsonPropertyName("plate_number")]
        public string PlateNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置司机资格证号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("driver_license")]
        [System.Text.Json.Serialization.JsonPropertyName("driver_license")]
        public string DriverLicenseNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置事件时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("event_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.RequestPropertyEventTimeNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("event_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.RequestPropertyEventTimeSystemTextJsonConverter))]
        public DateTimeOffset EventTime { get; set; }

        /// <summary>
        /// 获取或设置事件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("event_type")]
        [System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置行政区划代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("region_id")]
        [System.Text.Json.Serialization.JsonPropertyName("region_id")]
        public int RegionId { get; set; }
    }
}
