using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Newtonsoft.Json.Converters
{
    public class NumberTypedNullableBooleanConverter : JsonConverter<bool?>
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
            else if (reader.TokenType == JsonToken.Integer)
            {
                int value = serializer.Deserialize<int>(reader);
                return Convert.ToBoolean(value);
            }
            else if (reader.TokenType == JsonToken.String)
            {
                string? str = serializer.Deserialize<string>(reader);
                if (str == null)
                    return existingValue;

                if (int.TryParse(str, out int value))
                    return Convert.ToBoolean(value);
            }

            throw new JsonReaderException();
        }

        public override void WriteJson(JsonWriter writer, bool? value, JsonSerializer serializer)
        {
            if (value.HasValue)
                writer.WriteValue(value.Value ? 1 : 0);
            else
                writer.WriteNull();
        }
    }
}
