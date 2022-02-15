using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class TextualStringListWithPipeSplitConverter : JsonConverterFactory
    {
        private sealed class InnerTextualStringListWithVBarSplitConverter : JsonConverter<IList<string>?>
        {
            private readonly JsonConverter<string[]?> _converter = new TextualStringArrayWithPipeSplitConverter();

            public override IList<string>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                string[]? array = _converter.Read(ref reader, typeToConvert, options);
                IList<string>? list = array?.ToList();
                return list;
            }

            public override void Write(Utf8JsonWriter writer, IList<string>? value, JsonSerializerOptions options)
            {
                _converter.Write(writer, value?.ToArray(), options);
            }
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsGenericType &&
                   typeof(IList<>).IsAssignableFrom(typeToConvert.GetGenericTypeDefinition()) &&
                   typeof(string) == typeToConvert.GetGenericArguments()[0];
        }

        public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            return new InnerTextualStringListWithVBarSplitConverter();
        }
    }
}
