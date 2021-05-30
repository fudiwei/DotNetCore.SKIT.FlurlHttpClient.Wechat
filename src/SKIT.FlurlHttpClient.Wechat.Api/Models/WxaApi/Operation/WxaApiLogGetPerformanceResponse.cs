using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/log/jserr_list 接口的响应。</para>
    /// </summary>
    public class WxaApiLogGetPerformanceResponse : WechatApiResponse
    {
        public static class Types
        {
            public class DefaultTimeData
            {
                public static class Types
                {
                    public class Data
                    {
                        /// <summary>
                        /// 获取或设置数据的日期（格式：yyyyMMdd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ref_date")]
                        [System.Text.Json.Serialization.JsonPropertyName("ref_date")]
                        public string RefDateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置耗时类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cost_time_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("cost_time_type")]
                        public int CostTimeType { get; set; }

                        /// <summary>
                        /// 获取或设置耗时（单位：毫秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cost_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("cost_time")]
                        public int CostTime { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Data[] DataList { get; set; } = default!;
            }
        }

        internal static class Converters
        {
            internal class NewtonsoftJsonDefaultTimeDataConverter : Newtonsoft.Json.JsonConverter<Types.DefaultTimeData?>
            {
                public override bool CanRead
                {
                    get { return true; }
                }

                public override bool CanWrite
                {
                    get { return true; }
                }

                public override Types.DefaultTimeData? ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, Types.DefaultTimeData? existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
                {
                    if (reader.TokenType == Newtonsoft.Json.JsonToken.Null)
                    {
                        return existingValue;
                    }
                    else if (reader.TokenType == Newtonsoft.Json.JsonToken.String)
                    {
                        string? value = serializer.Deserialize<string>(reader);
                        if (value == null)
                            return existingValue;

                        return Newtonsoft.Json.JsonConvert.DeserializeObject<Types.DefaultTimeData>(value);
                    }

                    throw new Newtonsoft.Json.JsonReaderException();
                }

                public override void WriteJson(Newtonsoft.Json.JsonWriter writer, Types.DefaultTimeData? value, Newtonsoft.Json.JsonSerializer serializer)
                {
                    if (value != null)
                        writer.WriteValue(Newtonsoft.Json.JsonConvert.SerializeObject(value, Newtonsoft.Json.Formatting.None));
                    else
                        writer.WriteNull();
                }
            }

            internal class SystemTextJsonDefaultTimeDataConverter : System.Text.Json.Serialization.JsonConverter<Types.DefaultTimeData?>
            {
                public override Types.DefaultTimeData? Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
                {
                    if (reader.TokenType == System.Text.Json.JsonTokenType.Null)
                    {
                        return null;
                    }
                    else if (reader.TokenType == System.Text.Json.JsonTokenType.String)
                    {
                        string? value = reader.GetString();
                        if (value == null)
                            return null;

                        return System.Text.Json.JsonSerializer.Deserialize<Types.DefaultTimeData>(value, options);
                    }

                    throw new System.Text.Json.JsonException();
                }

                public override void Write(System.Text.Json.Utf8JsonWriter writer, Types.DefaultTimeData? value, System.Text.Json.JsonSerializerOptions options)
                {
                    if (value != null)
                        writer.WriteStringValue(System.Text.Json.JsonSerializer.Serialize(value, options));
                    else
                        writer.WriteNullValue();
                }
            }
        }

        /// <summary>
        /// 获取或设置查询数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("default_time_data")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.NewtonsoftJsonDefaultTimeDataConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("default_time_data")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.SystemTextJsonDefaultTimeDataConverter))]
        public Types.DefaultTimeData? DefaultTimeData { get; set; }

        /// <summary>
        /// 获取或设置比较数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("compare_time_data")]
        [System.Text.Json.Serialization.JsonPropertyName("compare_time_data")]
        public string? CompareTimeData { get; set; }
    }
}
