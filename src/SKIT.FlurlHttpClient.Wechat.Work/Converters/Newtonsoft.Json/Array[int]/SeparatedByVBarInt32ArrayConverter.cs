using System;
using System.Linq;

namespace Newtonsoft.Json.Converters
{
    internal class SeparatedByVBarInt32ArrayConverter : JsonConverter<int[]?>
    {
        private const string SEPARATOR = "|";

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override int[]? ReadJson(JsonReader reader, Type objectType, int[]? existingValue, bool hasExistingValue, JsonSerializer serializer)
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
                    return value
                        .Split(new string[] { SEPARATOR }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(e => int.Parse(e))
                        .ToArray();
                }
                catch (FormatException ex)
                {
                    throw new JsonReaderException(ex.Message, ex);
                }
            }

            throw new JsonReaderException();
        }

        public override void WriteJson(JsonWriter writer, int[]? value, JsonSerializer serializer)
        {
            if (value != null)
                writer.WriteValue(string.Join(SEPARATOR, value));
            else
                writer.WriteNull();
        }
    }
}
