using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class FlattenNArrayObjectConverterBase<T> : JsonConverter<T?>
        where T : class, new()
    {
        public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return default;
            }
            else if (reader.TokenType == JsonTokenType.StartObject)
            {
                JsonElement jElement = JsonDocument.ParseValue(ref reader).RootElement.Clone();
                return SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities.JsonUtility.DeserializeWhenHasNArray<T>(ref jElement, options);
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, T? value, JsonSerializerOptions options)
        {
            if (value != null)
                writer.WriteRawValue(SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities.JsonUtility.SerializeWhenHasNArray<T>(value, options));
            else
                writer.WriteNullValue();
        }
    }
}
