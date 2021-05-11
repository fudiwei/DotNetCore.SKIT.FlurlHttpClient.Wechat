using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    public class NumberTypedNullableBooleanConverter : JsonConverter<bool?>
    {
        public override bool? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }
            else if (reader.TokenType == JsonTokenType.True)
            {
                return true;
            }
            else if (reader.TokenType == JsonTokenType.False)
            {
                return false;
            }
            else if (reader.TokenType == JsonTokenType.Number)
            {
                if (reader.TryGetInt32(out int value))
                    return Convert.ToBoolean(value);
            }
            else if (reader.TokenType == JsonTokenType.String)
            {
                string? str = reader.GetString();
                if (str == null)
                    return null;

                if (int.TryParse(str, out int value))
                    return Convert.ToBoolean(value);
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, bool? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                writer.WriteNumberValue(value.Value ? 1 : 0);
            else
                writer.WriteNullValue();
        }
    }
}
