using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class StringTypedNullableBooleanConverter : JsonConverter<bool?>
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
            else if (reader.TokenType == JsonTokenType.String)
            {
                string? value = reader.GetString();
                if (value == null)
                    return null;

                if ("true".Equals(value, StringComparison.OrdinalIgnoreCase))
                    return true;
                else if ("false".Equals(value, StringComparison.OrdinalIgnoreCase))
                    return false;
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, bool? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                writer.WriteStringValue(value.Value ? "true" : "false");
            else
                writer.WriteNullValue();
        }
    }
}
