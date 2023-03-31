using System;
using System.Globalization;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /taxi-invoice/attendance/punch 接口的请求。</para>
    /// </summary>
    public class PunchTaxiInvoiceAttendanceRequest : WechatTenpayRequest
    {
        internal static class Converters
        {
            internal class RequestPropertyEventTimeNewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter<DateTimeOffset>
            {
                internal const string DATETIME_FORMAT = "yyyy-MM-dd'T'HH:mm:ss.fffzzz";

                public override bool CanRead { get { return true; } }

                public override bool CanWrite { get { return true; } }

                public override DateTimeOffset ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, DateTimeOffset existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
                {
                    switch (reader.TokenType)
                    {
                        case Newtonsoft.Json.JsonToken.Null:
                            {
                                return existingValue;
                            }

                        case Newtonsoft.Json.JsonToken.String:
                            {
                                string? value = serializer.Deserialize<string>(reader);
                                if (string.IsNullOrEmpty(value))
                                    return existingValue;

                                if (DateTimeOffset.TryParseExact(value, DATETIME_FORMAT, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out var result))
                                    return result;
                                if (DateTimeOffset.TryParse(value, out result))
                                    return result;

                                throw new Newtonsoft.Json.JsonSerializationException("Could not parse String '" + value + "' to DateTimeOffset.");
                            }

                        case Newtonsoft.Json.JsonToken.Date:
                            {
                                reader.DateFormatString = DATETIME_FORMAT;
                                return serializer.Deserialize<DateTimeOffset>(reader);
                            }
                    }

                    throw new Newtonsoft.Json.JsonSerializationException($"Unexpected token type '{reader.TokenType}' when deserializing. Path '{reader.Path}'.");
                }

                public override void WriteJson(Newtonsoft.Json.JsonWriter writer, DateTimeOffset value, Newtonsoft.Json.JsonSerializer serializer)
                {
                    writer.WriteValue(value.ToString(DATETIME_FORMAT, DateTimeFormatInfo.InvariantInfo));
                }
            }

            internal class RequestPropertyEventTimeSystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<DateTimeOffset>
            {
                internal const string DATETIME_FORMAT = "yyyy-MM-dd'T'HH:mm:ss.fffzzz";

                public override DateTimeOffset Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
                {
                    switch (reader.TokenType)
                    {
                        case System.Text.Json.JsonTokenType.Null:
                            {
                                return default!;
                            }

                        case System.Text.Json.JsonTokenType.String:
                            {
                                string? value = reader.GetString();
                                if (string.IsNullOrEmpty(value))
                                    return default;

                                if (DateTimeOffset.TryParseExact(value, DATETIME_FORMAT, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out var result))
                                    return result;
                                if (DateTimeOffset.TryParse(value, out result))
                                    return result;

                                throw new System.Text.Json.JsonException("Could not parse String '" + value + "' to DateTimeOffset.");
                            }
                    }

                    throw new System.Text.Json.JsonException($"Unexpected JSON token type '{reader.TokenType}' when reading.");
                }

                public override void Write(System.Text.Json.Utf8JsonWriter writer, DateTimeOffset value, System.Text.Json.JsonSerializerOptions options)
                {
                    writer.WriteStringValue(value.ToString(DATETIME_FORMAT, DateTimeFormatInfo.InvariantInfo));
                }
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
