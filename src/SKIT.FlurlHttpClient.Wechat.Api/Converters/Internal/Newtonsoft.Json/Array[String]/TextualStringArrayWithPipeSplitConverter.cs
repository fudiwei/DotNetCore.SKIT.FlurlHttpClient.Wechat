using System;

namespace Newtonsoft.Json.Converters
{
    internal class TextualStringArrayWithPipeSplitConverter : JsonConverter<string[]?>
    {
        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override string[]? ReadJson(JsonReader reader, Type objectType, string[]? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }
            else if (reader.TokenType == JsonToken.String)
            {
                string? value = serializer.Deserialize<string>(reader);
                if (value == null)
                    return null;
                if (string.IsNullOrEmpty(value))
                    return Array.Empty<string>();

                return value.Split('|');
            }

            throw new JsonSerializationException();
        }

        public override void WriteJson(JsonWriter writer, string[]? value, JsonSerializer serializer)
        {
            if (value != null)
                writer.WriteValue(string.Join("|", value));
            else
                writer.WriteNull();
        }
    }
}
