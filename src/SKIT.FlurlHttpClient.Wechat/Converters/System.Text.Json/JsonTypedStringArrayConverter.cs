using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    public class JsonTypedStringArrayConverter : JsonConverter<string[]?>
    {
        public override string[]? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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

                if (value.StartsWith("[") && value.EndsWith("["))
                    return JsonSerializer.Deserialize<string[]>(value, options);

                if (string.IsNullOrEmpty(value))
                    return new string[0];
                else
                    return new string[1] { value };
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, string[]? value, JsonSerializerOptions options)
        {
            if (value != null)
                writer.WriteStringValue(JsonSerializer.Serialize(value, options));
            else
                writer.WriteNullValue();
        }
    }
}
