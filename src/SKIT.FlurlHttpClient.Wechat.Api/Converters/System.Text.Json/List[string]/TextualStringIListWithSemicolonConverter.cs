using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class TextualStringIListWithSemicolonConverter : JsonConverter<IList<string>?>
    {
        private readonly JsonConverter<List<string>?> _converter = new TextualStringListWithSemicolonConverter();

        public override IList<string>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return _converter.Read(ref reader, typeToConvert, options)?.ToArray();
        }

        public override void Write(Utf8JsonWriter writer, IList<string>? value, JsonSerializerOptions options)
        {
            _converter.Write(writer, value?.ToList(), options);
        }
    }
}
