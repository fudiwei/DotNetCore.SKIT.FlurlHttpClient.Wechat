using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Newtonsoft.Json.Converters
{
    public class JsonTypedStringListConverter : JsonConverter<List<string>?>
    {
        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override List<string>? ReadJson(JsonReader reader, Type objectType, List<string>? existingValue, bool hasExistingValue, JsonSerializer serializer)
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

                return JsonConvert.DeserializeObject<List<string>>(value);
            }

            throw new JsonReaderException();
        }

        public override void WriteJson(JsonWriter writer, List<string>? value, JsonSerializer serializer)
        {
            if (value != null)
                writer.WriteValue(JsonConvert.SerializeObject(value, Formatting.None));
            else
                writer.WriteNull();
        }
    }
}
