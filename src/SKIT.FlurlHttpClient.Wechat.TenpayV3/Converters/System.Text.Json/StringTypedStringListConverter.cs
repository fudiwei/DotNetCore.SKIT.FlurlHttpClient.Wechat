using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    public class StringTypedStringListConverter : JsonConverter<List<string>?>
    {
        public override List<string>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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

                return JsonSerializer.Deserialize<List<string>>(value, options);
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, List<string>? value, JsonSerializerOptions options)
        {
            if (value != null)
                writer.WriteStringValue(JsonSerializer.Serialize(value, options));
            else
                writer.WriteNullValue();
        }
    }
}
