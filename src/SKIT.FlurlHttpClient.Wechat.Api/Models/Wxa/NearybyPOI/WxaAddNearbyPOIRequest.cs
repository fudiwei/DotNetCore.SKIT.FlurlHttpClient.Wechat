using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/addnearbypoi 接口的请求。</para>
    /// </summary>
    public class WxaAddNearbyPOIRequest : WechatApiRequest
    {
        public static class Types
        {
            public class Picture
            {
                /// <summary>
                /// 获取或设置门店图片 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public IList<string> PictureUrlList { get; set; } = new List<string>();
            }

            public class Service
            {
                public static class Types
                {
                    public class ServiceItem
                    {
                        /// <summary>
                        /// 获取或设置服务标签 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public int Id { get; set; }

                        /// <summary>
                        /// 获取或设置服务类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tpye")]
                        [System.Text.Json.Serialization.JsonPropertyName("tpye")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置服务名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string AppId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置服务落地页的路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("path")]
                        [System.Text.Json.Serialization.JsonPropertyName("path")]
                        public string Path { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置服务描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                        public string? Description { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置服务标签列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("service_infos")]
                public IList<Types.ServiceItem> ServiceList { get; set; } = new List<Types.ServiceItem>();
            }

            public class Kf
            {
                /// <summary>
                /// 获取或设置是否启用客服。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_kf")]
                [System.Text.Json.Serialization.JsonPropertyName("open_kf")]
                public bool IsOpen { get; set; }

                /// <summary>
                /// 获取或设置客服名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("kf_name")]
                [System.Text.Json.Serialization.JsonPropertyName("kf_name")]
                public string? KfName { get; set; }

                /// <summary>
                /// 获取或设置客服头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("kf_headimg")]
                [System.Text.Json.Serialization.JsonPropertyName("kf_headimg")]
                public string? KfHeadImageUrl { get; set; }
            }
        }

        internal static class Converters
        {
            internal class NewtonsoftJsonPictureConverter : Newtonsoft.Json.JsonConverter<Types.Picture?>
            {
                public override bool CanRead
                {
                    get { return true; }
                }

                public override bool CanWrite
                {
                    get { return true; }
                }

                public override Types.Picture? ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, Types.Picture? existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
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

                        return Newtonsoft.Json.JsonConvert.DeserializeObject<Types.Picture>(value);
                    }

                    throw new Newtonsoft.Json.JsonReaderException();
                }

                public override void WriteJson(Newtonsoft.Json.JsonWriter writer, Types.Picture? value, Newtonsoft.Json.JsonSerializer serializer)
                {
                    if (value != null)
                        writer.WriteValue(Newtonsoft.Json.JsonConvert.SerializeObject(value, Newtonsoft.Json.Formatting.None));
                    else
                        writer.WriteNull();
                }
            }

            internal class SystemTextJsonPictureConverter : System.Text.Json.Serialization.JsonConverter<Types.Picture?>
            {
                public override Types.Picture? Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
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

                        return System.Text.Json.JsonSerializer.Deserialize<Types.Picture>(value, options);
                    }

                    throw new System.Text.Json.JsonException();
                }

                public override void Write(System.Text.Json.Utf8JsonWriter writer, Types.Picture? value, System.Text.Json.JsonSerializerOptions options)
                {
                    if (value != null)
                        writer.WriteStringValue(System.Text.Json.JsonSerializer.Serialize(value, options));
                    else
                        writer.WriteNullValue();
                }
            }
            
            internal class NewtonsoftJsonServiceConverter : Newtonsoft.Json.JsonConverter<Types.Service?>
            {
                public override bool CanRead
                {
                    get { return true; }
                }

                public override bool CanWrite
                {
                    get { return true; }
                }

                public override Types.Service? ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, Types.Service? existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
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

                        return Newtonsoft.Json.JsonConvert.DeserializeObject<Types.Service>(value);
                    }

                    throw new Newtonsoft.Json.JsonReaderException();
                }

                public override void WriteJson(Newtonsoft.Json.JsonWriter writer, Types.Service? value, Newtonsoft.Json.JsonSerializer serializer)
                {
                    if (value != null)
                        writer.WriteValue(Newtonsoft.Json.JsonConvert.SerializeObject(value, Newtonsoft.Json.Formatting.None));
                    else
                        writer.WriteNull();
                }
            }

            internal class SystemTextJsonServiceConverter : System.Text.Json.Serialization.JsonConverter<Types.Service?>
            {
                public override Types.Service? Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
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

                        return System.Text.Json.JsonSerializer.Deserialize<Types.Service>(value, options);
                    }

                    throw new System.Text.Json.JsonException();
                }

                public override void Write(System.Text.Json.Utf8JsonWriter writer, Types.Service? value, System.Text.Json.JsonSerializerOptions options)
                {
                    if (value != null)
                        writer.WriteStringValue(System.Text.Json.JsonSerializer.Serialize(value, options));
                    else
                        writer.WriteNullValue();
                }
            }

            internal class NewtonsoftJsonKfConverter : Newtonsoft.Json.JsonConverter<Types.Kf?>
            {
                public override bool CanRead
                {
                    get { return true; }
                }

                public override bool CanWrite
                {
                    get { return true; }
                }

                public override Types.Kf? ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, Types.Kf? existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
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

                        return Newtonsoft.Json.JsonConvert.DeserializeObject<Types.Kf>(value);
                    }

                    throw new Newtonsoft.Json.JsonReaderException();
                }

                public override void WriteJson(Newtonsoft.Json.JsonWriter writer, Types.Kf? value, Newtonsoft.Json.JsonSerializer serializer)
                {
                    if (value != null)
                        writer.WriteValue(Newtonsoft.Json.JsonConvert.SerializeObject(value, Newtonsoft.Json.Formatting.None));
                    else
                        writer.WriteNull();
                }
            }

            internal class SystemTextJsonKfConverter : System.Text.Json.Serialization.JsonConverter<Types.Kf?>
            {
                public override Types.Kf? Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
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

                        return System.Text.Json.JsonSerializer.Deserialize<Types.Kf>(value, options);
                    }

                    throw new System.Text.Json.JsonException();
                }

                public override void Write(System.Text.Json.Utf8JsonWriter writer, Types.Kf? value, System.Text.Json.JsonSerializerOptions options)
                {
                    if (value != null)
                        writer.WriteStringValue(System.Text.Json.JsonSerializer.Serialize(value, options));
                    else
                        writer.WriteNullValue();
                }
            }
        }

        /// <summary>
        /// 获取或设置附近地点 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poi_id")]
        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
        public string POIId { get; set; } = string.Empty;

        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_comm_nearby")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_comm_nearby")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsCommonNearby { get; set; } = true;

        /// <summary>
        /// 获取或设置腾讯地图的位置点 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("map_poi_id")]
        [System.Text.Json.Serialization.JsonPropertyName("map_poi_id")]
        public string? MapPOIId { get; set; }

        /// <summary>
        /// 获取或设置门店图片信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pic_list")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.NewtonsoftJsonPictureConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("pic_list")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.SystemTextJsonPictureConverter))]
        public Types.Picture Picture { get; set; } = new Types.Picture();

        /// <summary>
        /// 获取或设置服务标签信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_infos")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.NewtonsoftJsonServiceConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("service_infos")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.SystemTextJsonServiceConverter))]
        public Types.Service Service { get; set; } = new Types.Service();

        /// <summary>
        /// 获取或设置客服信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kf_info")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.NewtonsoftJsonKfConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("kf_info")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.SystemTextJsonKfConverter))]
        public Types.Kf? Kf { get; set; }

        /// <summary>
        /// 获取或设置门店名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_name")]
        [System.Text.Json.Serialization.JsonPropertyName("store_name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置营业时间（格式：HHmm-HHmm）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hour")]
        [System.Text.Json.Serialization.JsonPropertyName("hour")]
        public string BusinessHours { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        [System.Text.Json.Serialization.JsonPropertyName("address")]
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置主体名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_name")]
        [System.Text.Json.Serialization.JsonPropertyName("company_name")]
        public string CompanyName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_phone")]
        public string TeleNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置经营资质证件号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("credential")]
        [System.Text.Json.Serialization.JsonPropertyName("credential")]
        public string LicenseNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置证明材料媒体文件标识列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qualification_list")]
        [System.Text.Json.Serialization.JsonPropertyName("qualification_list")]
        public IList<string>? QualificationMediaIdList { get; set; }
    }
}
