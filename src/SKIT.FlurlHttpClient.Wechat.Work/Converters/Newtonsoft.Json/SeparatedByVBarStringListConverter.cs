using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Newtonsoft.Json.Converters
{
    internal class SeparatedByVBarStringListConverter : JsonConverter<List<string>?>
    {
        private readonly JsonConverter<string[]?> _converter = new SeparatedByVBarStringArrayConverter();

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
            return _converter.ReadJson(reader, objectType, existingValue?.ToArray(), hasExistingValue, serializer)?.ToList();
        }

        public override void WriteJson(JsonWriter writer, List<string>? value, JsonSerializer serializer)
        {
            _converter.WriteJson(writer, value?.ToArray(), serializer);
        }
    }
}
