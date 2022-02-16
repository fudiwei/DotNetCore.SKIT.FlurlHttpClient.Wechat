using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    internal class TextualLongListWithPipeSplitConverter : JsonConverterFactory
    {
        private sealed class InnerTextualIntegerListWithVBarSplitConverter : JsonConverter<IList<long>?>
        {
            private readonly JsonConverter<long[]?> _converter = new TextualLongArrayWithPipeSplitConverter();

            public override IList<long>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                long[]? array = _converter.Read(ref reader, typeToConvert, options);
                IList<long>? list = array?.ToList();
                return list;
            }

            public override void Write(Utf8JsonWriter writer, IList<long>? value, JsonSerializerOptions options)
            {
                _converter.Write(writer, value?.ToArray(), options);
            }
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsGenericType &&
                   typeof(IList<>).IsAssignableFrom(typeToConvert.GetGenericTypeDefinition()) &&
                   typeof(long) == typeToConvert.GetGenericArguments()[0];
        }

        public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            return new InnerTextualIntegerListWithVBarSplitConverter();
        }
    }
}
