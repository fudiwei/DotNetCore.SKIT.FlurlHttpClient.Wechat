using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class SeparatedByVBarInt32ArrayConverter : JsonConverter<int[]?>
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

                try
                {
                    return value
                        .Split(new string[] { SEPARATOR }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(e => int.Parse(e))
                        .ToArray();
                }
                catch (FormatException ex)
                {
                    throw new JsonException(ex.Message, ex);
                }
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, int[]? value, JsonSerializerOptions options)
        {
            if (value != null)
                writer.WriteStringValue(string.Join(SEPARATOR, value));
            else
                writer.WriteNullValue();
        }
    }
}
