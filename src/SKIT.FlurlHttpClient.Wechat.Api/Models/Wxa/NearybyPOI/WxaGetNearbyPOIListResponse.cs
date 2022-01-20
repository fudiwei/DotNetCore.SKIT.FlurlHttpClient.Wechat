using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/getnearbypoilist 接口的响应。</para>
    /// </summary>
    public class WxaGetNearbyPOIListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class POI
                    {
                        public static class Types
                        {
                            public class POIItem
                            {
                                /// <summary>
                                /// 获取或设置附近地点 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("poi_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
                                public string POIId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置资质证件地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("qualification_address")]
                                [System.Text.Json.Serialization.JsonPropertyName("qualification_address")]
                                public string QualificationAddress { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置资质证件证件号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("qualification_num")]
                                [System.Text.Json.Serialization.JsonPropertyName("qualification_num")]
                                public string QualificationNumber { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置地点审核状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("audit_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("audit_status")]
                                public int AuditStatus { get; set; }

                                /// <summary>
                                /// 获取或设置地点展示在附近状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("display_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("display_status")]
                                public int DisplayStatus { get; set; }

                                /// <summary>
                                /// 获取或设置审核失败原因。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refuse_reason")]
                                [System.Text.Json.Serialization.JsonPropertyName("refuse_reason")]
                                public string? RefuseReason { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置附近地点列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi_list")]
                        public Types.POIItem[] POIList { get; set; } = default!;
                    }
                }

                public static class Convertes
                {
                    internal class NewtonsoftJsonPOIConverter : Newtonsoft.Json.JsonConverter<Types.POI?>
                    {
                        public override bool CanRead
                        {
                            get { return true; }
                        }

                        public override bool CanWrite
                        {
                            get { return true; }
                        }

                        public override Types.POI? ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, Types.POI? existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
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

                                return Newtonsoft.Json.JsonConvert.DeserializeObject<Types.POI>(value);
                            }

                            throw new Newtonsoft.Json.JsonReaderException();
                        }

                        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, Types.POI? value, Newtonsoft.Json.JsonSerializer serializer)
                        {
                            if (value != null)
                                writer.WriteValue(Newtonsoft.Json.JsonConvert.SerializeObject(value, Newtonsoft.Json.Formatting.None));
                            else
                                writer.WriteNull();
                        }
                    }

                    internal class SystemTextJsonPOIConverter : System.Text.Json.Serialization.JsonConverter<Types.POI?>
                    {
                        public override Types.POI? Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
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

                                return System.Text.Json.JsonSerializer.Deserialize<Types.POI>(value, options);
                            }

                            throw new System.Text.Json.JsonException();
                        }

                        public override void Write(System.Text.Json.Utf8JsonWriter writer, Types.POI? value, System.Text.Json.JsonSerializerOptions options)
                        {
                            if (value != null)
                                writer.WriteStringValue(System.Text.Json.JsonSerializer.Serialize(value, options));
                            else
                                writer.WriteNullValue();
                        }
                    }

                }

                /// <summary>
                /// 获取或设置剩余可添加地点个数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("left_apply_num")]
                [System.Text.Json.Serialization.JsonPropertyName("left_apply_num")]
                public int LeftApplyCount { get; set; }

                /// <summary>
                /// 获取或设置最大可添加地点个数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_apply_num")]
                [System.Text.Json.Serialization.JsonPropertyName("max_apply_num")]
                public int MaxApplyCount { get; set; }

                /// <summary>
                /// 获取或设置附近地点信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [Newtonsoft.Json.JsonConverter(typeof(Convertes.NewtonsoftJsonPOIConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                [System.Text.Json.Serialization.JsonConverter(typeof(Convertes.SystemTextJsonPOIConverter))]
                public Types.POI POI { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
