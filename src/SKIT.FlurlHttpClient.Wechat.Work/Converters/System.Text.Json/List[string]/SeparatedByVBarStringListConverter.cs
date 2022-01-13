using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class SeparatedByVBarStringListConverter : JsonConverter<List<string>?>
    {
        private readonly JsonConverter<string[]?> _converter = new SeparatedByVBarStringArrayConverter();

        public override List<string>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return _converter.Read(ref reader, typeToConvert, options)?.ToList();
        }

        public override void Write(Utf8JsonWriter writer, List<string>? value, JsonSerializerOptions options)
        {
            _converter.Write(writer, value?.ToArray(), options);
        }
    }
}
