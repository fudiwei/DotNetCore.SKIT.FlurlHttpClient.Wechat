using System;

namespace Newtonsoft.Json.Converters
{
    internal class YesOrNoNullableBooleanConverter : JsonConverter<bool?>
    {
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
                if (value == null)
                    return existingValue;

                if ("Y".Equals(value))
                    return true;
                else if ("N".Equals(value))
                    return false;
            }

            throw new JsonReaderException();
        }

        public override void WriteJson(JsonWriter writer, bool? value, JsonSerializer serializer)
        {
            if (value.HasValue)
                writer.WriteValue(value.Value ? "Y" : "N");
            else
                writer.WriteNull();
        }
    }
}
