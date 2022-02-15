using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/update_store 接口的请求。</para>
    /// </summary>
    public class WxaUpdateStoreRequest : WechatApiRequest, IMapResponse<WxaUpdateStoreRequest, WxaUpdateStoreResponse>
    {
        public static class Types
        {
            public class Picture : WxaAddStoreRequest.Types.Picture
            {
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
        }

        /// <summary>
        /// 获取或设置门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poi_id")]
        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
        public string POIId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置腾讯地图的位置点 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("map_poi_id")]
        [System.Text.Json.Serialization.JsonPropertyName("map_poi_id")]
        public string MapPOIId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店图片信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pic_list")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.NewtonsoftJsonPictureConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("pic_list")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.SystemTextJsonPictureConverter))]
        public Types.Picture Picture { get; set; } = new Types.Picture();

        /// <summary>
        /// 获取或设置营业时间（格式：HHmm-HHmm）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hour")]
        [System.Text.Json.Serialization.JsonPropertyName("hour")]
        public string BusinessHours { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_phone")]
        public string Telephone { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置卡券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = string.Empty;
    }
}
