using System.Text.Json;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class AbstractObjectIsJsonConverter<T> : JsonConverter<T?>
        where T : class
    {
        public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return default;
            }
            else if (reader.TokenType == JsonTokenType.String)
            {
                string? value = reader.GetString();
                if (value == null)
                    return null;

                return JsonSerializer.Deserialize<T>(value);
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, T? value, JsonSerializerOptions options)
        {
            if (value != null)
                writer.WriteStringValue(JsonSerializer.Serialize(value, options));
            else
                writer.WriteNullValue();
        }
    }
}
