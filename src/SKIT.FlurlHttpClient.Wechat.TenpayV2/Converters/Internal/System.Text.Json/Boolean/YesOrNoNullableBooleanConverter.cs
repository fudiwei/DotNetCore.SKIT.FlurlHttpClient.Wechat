using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class YesOrNoNullableBooleanConverter : JsonConverter<bool?>
    {
        private const string CHAR_YES = "Y";
        private const string CHAR_NO = "N";

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
                if (string.IsNullOrEmpty(value))
                    return null;

                if (CHAR_YES.Equals(value))
                    return true;
                else if (CHAR_NO.Equals(value))
                    return false;
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, bool? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                writer.WriteStringValue(value.Value ? CHAR_YES : CHAR_NO);
            else
                writer.WriteNullValue();
        }
    }
}
