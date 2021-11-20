using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class TextualStringArrayWithSemicolonConverter : JsonConverter<string[]?>
    {
        private readonly JsonConverter<List<string>?> _converter = new TextualStringListWithSemicolonConverter();

        public override string[]? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return _converter.Read(ref reader, typeToConvert, options)?.ToArray();
        }

        public override void Write(Utf8JsonWriter writer, string[]? value, JsonSerializerOptions options)
        {
            _converter.Write(writer, value?.ToList(), options);
        }
    }
}
