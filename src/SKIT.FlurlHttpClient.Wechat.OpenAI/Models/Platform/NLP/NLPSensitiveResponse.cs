using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.Platform
{
    /// <summary>
    /// <para>表示 [POST] /nlp/sensitive/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class NLPSensitiveResponse : WechatOpenAIPlatformResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置敏感信息项。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                public string Sensitive { get; set; } = default!;

                /// <summary>
                /// 获取或设置分值（范围：0～1）。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                public double Score { get; set; }
            }
        }

        internal static class Converters
        {
            internal class ResponsePropertyResultArrayNewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter<Types.Result[]?>
            {
                public override bool CanRead
                {
                    get { return true; }
                }

                public override bool CanWrite
                {
                    get { return true; }
                }

                public override Types.Result[]? ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, Types.Result[]? existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
                {
                    if (reader.TokenType == Newtonsoft.Json.JsonToken.Null)
                    {
                        return existingValue;
                    }
                    else if (reader.TokenType == Newtonsoft.Json.JsonToken.StartArray)
                    {
                        reader.Read();

                        var tmpList = new List<Types.Result>();

                        while (reader.TokenType != Newtonsoft.Json.JsonToken.EndArray)
                        {
                            if (reader.TokenType == Newtonsoft.Json.JsonToken.StartArray)
                            {
                                reader.Read();

                                int offset = 0;
                                var tmpItem = new Types.Result();

                                while (reader.TokenType != Newtonsoft.Json.JsonToken.EndArray)
                                {
                                    if (offset == 0)
                                    {
                                        tmpItem.Sensitive = serializer.Deserialize<string>(reader)!;
                                    }
                                    else if (offset == 1)
                                    {
                                        tmpItem.Score = serializer.Deserialize<double>(reader);
                                    }

                                    offset++;
                                    reader.Read();
                                }

                                tmpList.Add(tmpItem);
                            }

                            reader.Read();
                        }

                        return tmpList.ToArray();
                    }

                    throw new Newtonsoft.Json.JsonReaderException();
                }

                public override void WriteJson(Newtonsoft.Json.JsonWriter writer, Types.Result[]? value, Newtonsoft.Json.JsonSerializer serializer)
                {
                    if (value != null)
                    {
                        writer.WriteStartArray();

                        foreach (var item in value)
                        {
                            writer.WriteStartArray();
                            writer.WriteValue(item.Sensitive);
                            writer.WriteValue(item.Score);
                            writer.WriteEndArray();
                        }

                        writer.WriteEndArray();
                    }
                    else
                    {
                        writer.WriteNull();
                    }
                }
            }

            internal class ResponsePropertyResultArraySystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<Types.Result[]?>
            {
                public override Types.Result[]? Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
                {
                    if (reader.TokenType == System.Text.Json.JsonTokenType.Null)
                    {
                        return null;
                    }
                    else if (reader.TokenType == System.Text.Json.JsonTokenType.StartArray)
                    {
                        reader.Read();

                        var tmpList = new List<Types.Result>();
                        var tmpOptions = new System.Text.Json.JsonSerializerOptions(options);

                        while (reader.TokenType != System.Text.Json.JsonTokenType.EndArray)
                        {
                            if (reader.TokenType == System.Text.Json.JsonTokenType.StartArray)
                            {
                                reader.Read();

                                int offset = 0;
                                var tmpItem = new Types.Result();

                                while (reader.TokenType != System.Text.Json.JsonTokenType.EndArray)
                                {
                                    if (offset == 0)
                                    {
                                        tmpItem.Sensitive = System.Text.Json.JsonSerializer.Deserialize<string>(ref reader, tmpOptions)!;
                                    }
                                    else if (offset == 1)
                                    {
                                        tmpItem.Score = System.Text.Json.JsonSerializer.Deserialize<double>(ref reader, tmpOptions);
                                    }

                                    offset++;
                                    reader.Read();
                                }

                                tmpList.Add(tmpItem);
                            }

                            reader.Read();
                        }

                        return tmpList.ToArray();
                    }

                    throw new System.Text.Json.JsonException();
                }

                public override void Write(System.Text.Json.Utf8JsonWriter writer, Types.Result[]? value, System.Text.Json.JsonSerializerOptions options)
                {
                    if (value != null)
                    {
                        writer.WriteStartArray();

                        foreach (var item in value)
                        {
                            writer.WriteStartArray();
                            writer.WriteStringValue(item.Sensitive);
                            writer.WriteNumberValue(item.Score);
                            writer.WriteEndArray();
                        }

                        writer.WriteEndArray();
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }
                }
            }
        }

        /// <summary>
        /// 获取或设置结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponsePropertyResultArrayNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponsePropertyResultArraySystemTextJsonConverter))]
        public Types.Result[] ResultList { get; set; } = default!;
    }
}
