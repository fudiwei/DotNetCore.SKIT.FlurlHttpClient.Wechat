﻿using System;

namespace Newtonsoft.Json.Converters
{
    internal class SeparatedByVBarStringArrayConverter : JsonConverter<string[]?>
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

                return value.Split(new string[] { SEPARATOR }, StringSplitOptions.RemoveEmptyEntries);
            }

            throw new JsonReaderException();
        }

        public override void WriteJson(JsonWriter writer, string[]? value, JsonSerializer serializer)
        {
            if (value != null)
                writer.WriteValue(string.Join(SEPARATOR, value));
            else
                writer.WriteNull();
        }
    }
}
