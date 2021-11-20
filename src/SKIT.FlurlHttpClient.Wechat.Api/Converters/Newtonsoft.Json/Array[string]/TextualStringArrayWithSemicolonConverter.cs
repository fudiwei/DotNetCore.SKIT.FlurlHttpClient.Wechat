using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Newtonsoft.Json.Converters
{
    internal class TextualStringArrayWithSemicolonConverter : JsonConverter<string[]?>
    {
        private readonly JsonConverter<List<string>?> _converter = new TextualStringListWithSemicolonConverter();

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
            return _converter.ReadJson(reader, objectType, existingValue?.ToList(), hasExistingValue, serializer)?.ToArray();
        }

        public override void WriteJson(JsonWriter writer, string[]? value, JsonSerializer serializer)
        {
            _converter.WriteJson(writer, value?.ToList(), serializer);
        }
    }
}
