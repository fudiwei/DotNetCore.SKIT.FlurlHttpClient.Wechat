using System;
using System.Collections.Generic;

/* @codestyle-disable no-instantiated-property-in-response */
namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.Platform
{
    /// <summary>
    /// <para>表示 [POST] /nlp/ner-product/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class NLPNERProductResponse : WechatOpenAIPlatformResponse
    {
        public static class Types
        {
            public class Result
            {
                public static class Types
                {
                    public class ProductProperty
                    {
                        /// <summary>
                        /// 获取或设置商品属性名。
                        /// </summary>
                        [Newtonsoft.Json.JsonIgnore]
                        [System.Text.Json.Serialization.JsonIgnore]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品属性值。
                        /// </summary>
                        [Newtonsoft.Json.JsonIgnore]
                        [System.Text.Json.Serialization.JsonIgnore]
                        public string Value { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置起始字符位置。
                        /// </summary>
                        [Newtonsoft.Json.JsonIgnore]
                        [System.Text.Json.Serialization.JsonIgnore]
                        public int StartIndex { get; set; }

                        /// <summary>
                        /// 获取或设置结束字符位置。
                        /// </summary>
                        [Newtonsoft.Json.JsonIgnore]
                        [System.Text.Json.Serialization.JsonIgnore]
                        public int EndIndex { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product")]
                [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponsePropertyProductPropertyArrayNewtonsoftJsonConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("product")]
                [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponsePropertyProductPropertyArraySystemTextJsonConverter))]
                public Types.ProductProperty[] ProductPropertyList { get; set; } = default!;
            }
        }

        internal static class Converters
        {
            internal class ResponsePropertyProductPropertyArrayNewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter<Types.Result.Types.ProductProperty[]?>
            {
                public override bool CanRead
                {
                    get { return true; }
                }

                public override bool CanWrite
                {
                    get { return true; }
                }

                public override Types.Result.Types.ProductProperty[]? ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, Types.Result.Types.ProductProperty[]? existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
                {
                    if (reader.TokenType == Newtonsoft.Json.JsonToken.Null)
                    {
                        return existingValue;
                    }
                    else if (reader.TokenType == Newtonsoft.Json.JsonToken.StartArray)
                    {
                        reader.Read();

                        var tmpList = new List<Types.Result.Types.ProductProperty>();

                        while (reader.TokenType != Newtonsoft.Json.JsonToken.EndArray)
                        {
                            if (reader.TokenType == Newtonsoft.Json.JsonToken.StartArray)
                            {
                                reader.Read();

                                int offset = 0;
                                var tmpItem = new Types.Result.Types.ProductProperty();

                                while (reader.TokenType != Newtonsoft.Json.JsonToken.EndArray)
                                {
                                    if (offset == 0)
                                    {
                                        tmpItem.Value = serializer.Deserialize<string>(reader)!;
                                    }
                                    else if (offset == 1)
                                    {
                                        tmpItem.Name = serializer.Deserialize<string>(reader)!;
                                    }
                                    else if (offset == 2)
                                    {
                                        tmpItem.StartIndex = serializer.Deserialize<int>(reader);
                                    }
                                    else if (offset == 3)
                                    {
                                        tmpItem.EndIndex = serializer.Deserialize<int>(reader);
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

                public override void WriteJson(Newtonsoft.Json.JsonWriter writer, Types.Result.Types.ProductProperty[]? value, Newtonsoft.Json.JsonSerializer serializer)
                {
                    if (value != null)
                    {
                        writer.WriteStartArray();

                        foreach (var item in value)
                        {
                            writer.WriteStartArray();
                            writer.WriteValue(item.Value);
                            writer.WriteValue(item.Name);
                            writer.WriteValue(item.StartIndex);
                            writer.WriteValue(item.EndIndex);
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

            internal class ResponsePropertyProductPropertyArraySystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<Types.Result.Types.ProductProperty[]?>
            {
                public override Types.Result.Types.ProductProperty[]? Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
                {
                    if (reader.TokenType == System.Text.Json.JsonTokenType.Null)
                    {
                        return null;
                    }
                    else if (reader.TokenType == System.Text.Json.JsonTokenType.StartArray)
                    {
                        reader.Read();

                        var tmpList = new List<Types.Result.Types.ProductProperty>();
                        var tmpOptions = new System.Text.Json.JsonSerializerOptions(options);

                        while (reader.TokenType != System.Text.Json.JsonTokenType.EndArray)
                        {
                            if (reader.TokenType == System.Text.Json.JsonTokenType.StartArray)
                            {
                                reader.Read();

                                int offset = 0;
                                var tmpItem = new Types.Result.Types.ProductProperty();

                                while (reader.TokenType != System.Text.Json.JsonTokenType.EndArray)
                                {
                                    if (offset == 0)
                                    {
                                        tmpItem.Value = System.Text.Json.JsonSerializer.Deserialize<string>(ref reader, tmpOptions)!;
                                    }
                                    else if (offset == 1)
                                    {
                                        tmpItem.Name = System.Text.Json.JsonSerializer.Deserialize<string>(ref reader, tmpOptions)!;
                                    }
                                    else if (offset == 2)
                                    {
                                        tmpItem.StartIndex = System.Text.Json.JsonSerializer.Deserialize<int>(ref reader, tmpOptions);
                                    }
                                    else if (offset == 3)
                                    {
                                        tmpItem.EndIndex = System.Text.Json.JsonSerializer.Deserialize<int>(ref reader, tmpOptions);
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

                public override void Write(System.Text.Json.Utf8JsonWriter writer, Types.Result.Types.ProductProperty[]? value, System.Text.Json.JsonSerializerOptions options)
                {
                    if (value != null)
                    {
                        writer.WriteStartArray();

                        foreach (var item in value)
                        {
                            writer.WriteStartArray();
                            writer.WriteStringValue(item.Value);
                            writer.WriteStringValue(item.Name);
                            writer.WriteNumberValue(item.StartIndex);
                            writer.WriteNumberValue(item.EndIndex);
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
        /// 获取或设置预处理后的文本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("preprocessed_text")]
        [System.Text.Json.Serialization.JsonPropertyName("preprocessed_text")]
        public string PreprocessedText { get; set; } = default!;

        /// <summary>
        /// 获取或设置抽取结果信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entities")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponsePropertyProductPropertyArrayNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("entities")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponsePropertyProductPropertyArraySystemTextJsonConverter))]
        public Types.Result Result { get; set; } = default!;
    }
}
