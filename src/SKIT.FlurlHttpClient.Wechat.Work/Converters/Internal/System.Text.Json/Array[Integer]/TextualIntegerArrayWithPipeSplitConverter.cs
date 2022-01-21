using System.Linq;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class TextualIntegerArrayWithPipeSplitConverter : JsonConverter<int[]?>
    {
        private const string SEPARATOR = "|";

        public override int[]? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }
            else if (reader.TokenType == JsonTokenType.String)
            {
                string? value = reader.GetString();
                if (value == null)
                    return null;
                if (string.IsNullOrEmpty(value))
                    return Array.Empty<int>();

                string[] strArr = value.Split('|');
                int[] intArr = new int[strArr.Length];
                for (int i = 0; i < strArr.Length; i++)
                {
                    if (!int.TryParse(strArr[i], out int j))
                        throw new JsonException("Unexpected token when parsing string to integer.");

                    intArr[i] = j;
                }
                return intArr;
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, int[]? value, JsonSerializerOptions options)
        {
            if (value != null)
                writer.WriteStringValue(string.Join("|", value));
            else
                writer.WriteNullValue();
        }
    }
}
