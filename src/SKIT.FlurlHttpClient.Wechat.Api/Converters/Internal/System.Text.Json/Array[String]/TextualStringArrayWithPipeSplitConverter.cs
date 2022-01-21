using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class TextualStringArrayWithPipeSplitConverter : JsonConverter<string[]?>
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
                if (string.IsNullOrEmpty(value))
                    return Array.Empty<string>();

                return value.Split('|');
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, string[]? value, JsonSerializerOptions options)
        {
            if (value != null)
                writer.WriteStringValue(string.Join("|", value));
            else
                writer.WriteNullValue();
        }
    }
}
