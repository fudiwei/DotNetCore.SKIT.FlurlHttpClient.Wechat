using System;
using System.Collections.Generic;
using System.Linq;

namespace Newtonsoft.Json.Converters
{
    internal class TextualInt32ListConverter : JsonConverter<List<int>?>
    {
        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override List<int>? ReadJson(JsonReader reader, Type objectType, List<int>? existingValue, bool hasExistingValue, JsonSerializer serializer)
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

                try
                {
                    return value.Split(',').Select(e => int.Parse(e.Trim())).ToList();
                }
                catch (Exception ex)
                {
                    throw new JsonReaderException(ex.Message, ex);
                }
            }

            throw new JsonReaderException();
        }

        public override void WriteJson(JsonWriter writer, List<int>? value, JsonSerializer serializer)
        {
            if (value != null)
                writer.WriteValue(string.Join(",", value));
            else
                writer.WriteNull();
        }
    }
}
