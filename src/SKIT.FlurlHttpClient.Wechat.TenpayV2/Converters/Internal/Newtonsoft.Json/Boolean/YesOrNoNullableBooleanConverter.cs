using System;

namespace Newtonsoft.Json.Converters
{
    internal class YesOrNoNullableBooleanConverter : JsonConverter<bool?>
    {
        private const string CHAR_YES = "Y";
        private const string CHAR_NO = "N";

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override bool? ReadJson(JsonReader reader, Type objectType, bool? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return existingValue;
            }
            else if (reader.TokenType == JsonToken.Boolean)
            {
                return serializer.Deserialize<bool>(reader);
            }
            else if (reader.TokenType == JsonToken.String)
            {
                string? value = serializer.Deserialize<string>(reader);
                if (string.IsNullOrEmpty(value))
                    return existingValue;

                if (CHAR_YES.Equals(value))
                    return true;
                else if (CHAR_NO.Equals(value))
                    return false;
            }

            throw new JsonReaderException();
        }

        public override void WriteJson(JsonWriter writer, bool? value, JsonSerializer serializer)
        {
            if (value.HasValue)
                writer.WriteValue(value.Value ? CHAR_YES : CHAR_NO);
            else
                writer.WriteNull();
        }
    }
}
