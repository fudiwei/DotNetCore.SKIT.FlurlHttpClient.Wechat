using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class TextualLongArrayConverter : JsonConverter<long[]?>
    {
        public override long[]? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }
            else if (reader.TokenType == JsonTokenType.StartArray)
            {
                IList<long> list = new List<long>();

                while (reader.Read())
                {
                    switch (reader.TokenType)
                    {
                        case JsonTokenType.Number:
                            {
                                long value = reader.GetInt64();
                                list.Add(value);
                            }
                            break;

                        case JsonTokenType.String:
                            {
                                string? value = reader.GetString();
                                if (!long.TryParse(value, out long l))
                                    throw new JsonException($"Could not parse String '{value}' to Long.");

                                list.Add(l);
                            }
                            break;

                        case JsonTokenType.EndArray:
                            return list.ToArray();

                        case JsonTokenType.Comment:
                            break;

                        default:
                            throw new JsonException($"Unexpected JSON token type '{reader.TokenType}' when reading.");
                    }
                }
            }

            throw new JsonException($"Unexpected JSON token type '{reader.TokenType}' when reading.");
        }

        public override void Write(Utf8JsonWriter writer, long[]? value, JsonSerializerOptions options)
        {
            if (value != null)
            {
                writer.WriteStartArray();

                foreach (long l in value)
                {
                    writer.WriteStringValue(l.ToString());
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
