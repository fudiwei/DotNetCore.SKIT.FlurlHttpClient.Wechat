using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Newtonsoft.Json.Converters
{
    public class StringTypedStringArrayConverter : JsonConverter<string[]?>
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
                    return existingValue;
                    
                if (value.StartsWith("[") && value.EndsWith("["))
                    return JsonConvert.DeserializeObject<string[]>(value);

                if (string.IsNullOrEmpty(value))
                    return new string[0];
                else
                    return new string[1] { value };
            }

            throw new JsonReaderException();
        }

        public override void WriteJson(JsonWriter writer, string[]? value, JsonSerializer serializer)
        {
            if (value != null)
                writer.WriteValue(JsonConvert.SerializeObject(value, Formatting.None));
            else
                writer.WriteNull();
        }
    }
}
