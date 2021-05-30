using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/tag/addtagusers 接口的响应。</para>
    /// </summary>
    public class CgibinTagAddTagUsersResponse : WechatWorkResponse
    {
        internal static class Converters
        {
            internal class NewtonsoftJsonInvalidUserIdListConverter : Newtonsoft.Json.JsonConverter<string[]?>
            {
                public override bool CanRead
                {
                    get { return true; }
                }

                public override bool CanWrite
                {
                    get { return true; }
                }

                public override string[]? ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, string[]? existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
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

                        return value.Split('|');
                    }

                    throw new Newtonsoft.Json.JsonReaderException();
                }

                public override void WriteJson(Newtonsoft.Json.JsonWriter writer, string[]? value, Newtonsoft.Json.JsonSerializer serializer)
                {
                    if (value != null)
                        writer.WriteValue(string.Join("|", value));
                    else
                        writer.WriteNull();
                }
            }

            internal class SystemTextJsonInvalidUserIdListConverter : System.Text.Json.Serialization.JsonConverter<string[]?>
            {
                public override string[]? Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
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

                        return value.Split('|');
                    }

                    throw new System.Text.Json.JsonException();
                }

                public override void Write(System.Text.Json.Utf8JsonWriter writer, string[]? value, System.Text.Json.JsonSerializerOptions options)
                {
                    if (value != null)
                        writer.WriteStringValue(string.Join("|", value));
                    else
                        writer.WriteNullValue();
                }
            }
        }

        /// <summary>
        /// 获取或设置非法成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalidlist")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.NewtonsoftJsonInvalidUserIdListConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("invalidlist")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.SystemTextJsonInvalidUserIdListConverter))]
        public string[]? InvalidUserIdList { get; set; }

        /// <summary>
        /// 获取或设置非法部门 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalidparty")]
        [System.Text.Json.Serialization.JsonPropertyName("invalidparty")]
        public int[]? InvalidDepartmentIdList { get; set; }
    }
}
