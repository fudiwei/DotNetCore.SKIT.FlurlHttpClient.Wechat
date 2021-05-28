using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    public class NumberTypedStringConverter : JsonConverter<string?>
    {
        public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }
            else if (reader.TokenType == JsonTokenType.Number)
            {
                if (reader.TryGetInt64(out long valueAsInt64))
                    return valueAsInt64.ToString();
                else if (reader.TryGetUInt64(out ulong valueAsUInt64))
                    return valueAsUInt64.ToString();
                else if (reader.TryGetDouble(out double valueAsDouble))
                    return valueAsDouble.ToString();
                else
                    return reader.GetDecimal().ToString();
            }
            else if (reader.TokenType == JsonTokenType.String)
            {
                return reader.GetString();
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, string? value, JsonSerializerOptions options)
        {
            if (value != null)
            {
                if (long.TryParse(value, out long valueAsInt64))
                    writer.WriteNumberValue(valueAsInt64);
                else if (ulong.TryParse(value, out ulong valueAsUInt64))
                    writer.WriteNumberValue(valueAsUInt64);
                else if (double.TryParse(value, out double valueAsDouble))
                    writer.WriteNumberValue(valueAsDouble);
                else
                    writer.WriteStringValue(value);
            }
            else
            {
                writer.WriteNullValue();
            }
        }
    }
}
