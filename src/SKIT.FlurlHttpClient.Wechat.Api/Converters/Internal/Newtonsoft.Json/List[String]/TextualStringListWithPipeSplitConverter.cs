using System;
using System.Collections.Generic;
using System.Linq;

namespace Newtonsoft.Json.Converters
{
    internal class TextualStringListWithPipeSplitConverter : JsonConverter
    {
        private readonly JsonConverter<string[]?> _converter = new TextualStringArrayWithPipeSplitConverter();

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsGenericType &&
                   typeof(IList<>).IsAssignableFrom(objectType.GetGenericTypeDefinition()) &&
                   typeof(string) == objectType.GetGenericArguments()[0];
        }

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            string[]? array = _converter.ReadJson(reader, objectType, null, false, serializer);
            return array?.ToList();
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            _converter.WriteJson(writer, ((IList<string>?)value)?.ToArray(), serializer);
        }
    }
}
