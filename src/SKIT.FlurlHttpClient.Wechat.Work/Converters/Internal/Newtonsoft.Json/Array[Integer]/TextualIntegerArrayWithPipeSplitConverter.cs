using System;

namespace Newtonsoft.Json.Converters
{
    internal class TextualIntegerArrayWithPipeSplitConverter : JsonConverter<int[]?>
    {
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
                    return null;
                if (string.IsNullOrEmpty(value))
                    return Array.Empty<int>();

                string[] strArr = value.Split('|');
                int[] intArr = new int[strArr.Length];
                for (int i = 0; i < strArr.Length; i++)
                {
                    if (!int.TryParse(strArr[i], out int j))
                        throw new JsonSerializationException("Unexpected token when parsing string to integer.");

                    intArr[i] = j;
                }
                return intArr;
            }

            throw new JsonSerializationException();
        }

        public override void WriteJson(JsonWriter writer, int[]? value, JsonSerializer serializer)
        {
            if (value != null)
                writer.WriteValue(string.Join("|", value));
            else
                writer.WriteNull();
        }
    }
}
