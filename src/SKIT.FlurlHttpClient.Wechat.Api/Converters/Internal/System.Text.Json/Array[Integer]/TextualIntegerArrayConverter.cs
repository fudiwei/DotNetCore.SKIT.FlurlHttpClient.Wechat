using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class TextualIntegerArrayConverter : JsonConverter<int[]?>
    {
        public override int[]? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }
            else if (reader.TokenType == JsonTokenType.StartArray)
            {
                IList<int> list = new List<int>();

                while (reader.Read())
                {
                    switch (reader.TokenType)
                    {
                        case JsonTokenType.Number:
                            {
                                int value = reader.GetInt32();
                                list.Add(value);
                            }
                            break;

                        case JsonTokenType.String:
                            {
                                string? value = reader.GetString();
                                if (!int.TryParse(value, out int l))
                                    throw new JsonException($"Could not parse String '{value}' to Integer.");

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

        public override void Write(Utf8JsonWriter writer, int[]? value, JsonSerializerOptions options)
        {
            if (value != null)
            {
                writer.WriteStartArray();

                foreach (int i in value)
                {
                    writer.WriteStringValue(i.ToString());
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
