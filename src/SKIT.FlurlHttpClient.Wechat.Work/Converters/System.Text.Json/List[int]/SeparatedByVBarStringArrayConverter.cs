using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class SeparatedByVBarStringArrayConverter : JsonConverter<string[]?>
    {
        private const string SEPARATOR = "|";

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

                return value.Split(new string[] { SEPARATOR }, StringSplitOptions.RemoveEmptyEntries);
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, string[]? value, JsonSerializerOptions options)
        {
            if (value != null)
                writer.WriteStringValue(string.Join(SEPARATOR, value));
            else
                writer.WriteNullValue();
        }
    }
}
