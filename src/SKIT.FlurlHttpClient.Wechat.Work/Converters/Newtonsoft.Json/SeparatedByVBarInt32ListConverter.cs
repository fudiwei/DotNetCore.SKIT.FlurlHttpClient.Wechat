using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Newtonsoft.Json.Converters
{
    internal class SeparatedByVBarInt32ListConverter : JsonConverter<List<int>?>
    {
        private readonly JsonConverter<int[]?> _converter = new SeparatedByVBarInt32ArrayConverter();

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
            return _converter.ReadJson(reader, objectType, existingValue?.ToArray(), hasExistingValue, serializer)?.ToList();
        }

        public override void WriteJson(JsonWriter writer, List<int>? value, JsonSerializer serializer)
        {
            _converter.WriteJson(writer, value?.ToArray(), serializer);
        }
    }
}
