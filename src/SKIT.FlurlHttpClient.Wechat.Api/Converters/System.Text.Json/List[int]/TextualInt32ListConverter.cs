using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class TextualInt32ListConverter : JsonConverter<List<int>?>
    {
        public override List<int>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }
            else if (reader.TokenType == JsonTokenType.String)
            {
                string? value = reader.GetString();
                if (value == null)
                    return null;

                try
                {
                    return value.Split(',').Select(e => int.Parse(e.Trim())).ToList();
                }
                catch (Exception ex)
                {
                    throw new JsonException(ex.Message, ex);
                }
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, List<int>? value, JsonSerializerOptions options)
        {
            if (value != null)
                writer.WriteStringValue(string.Join(",", value));
            else
                writer.WriteNullValue();
        }
    }
}
