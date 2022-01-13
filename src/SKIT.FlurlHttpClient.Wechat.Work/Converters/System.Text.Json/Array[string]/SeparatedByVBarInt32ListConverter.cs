using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class SeparatedByVBarInt32ListConverter : JsonConverter<List<int>?>
    {
        private readonly JsonConverter<int[]?> _converter = new SeparatedByVBarInt32ArrayConverter();

        public override List<int>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return _converter.Read(ref reader, typeToConvert, options)?.ToList();
        }

        public override void Write(Utf8JsonWriter writer, List<int>? value, JsonSerializerOptions options)
        {
            _converter.Write(writer, value?.ToArray(), options);
        }
    }
}
