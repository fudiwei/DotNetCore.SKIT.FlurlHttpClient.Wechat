using System;
using System.IO;
using Flurl.Http.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SKIT.FlurlHttpClient.Wechat
{
    public class FlurlNewtonsoftJsonSerializer : ISerializer
    {
        private readonly JsonSerializerSettings _settings;

        public FlurlNewtonsoftJsonSerializer()
            : this(GetDefaultSerializerSettings())
        {
        }

        public FlurlNewtonsoftJsonSerializer(JsonSerializerSettings settings)
        {
            if (settings == null) throw new ArgumentNullException(nameof(settings));

            _settings = settings;
        }

        public static JsonSerializerSettings GetDefaultSerializerSettings()
        {
            var jsonSettings = new JsonSerializerSettings();
            jsonSettings.ReferenceLoopHandling = ReferenceLoopHandling.Serialize;
            jsonSettings.PreserveReferencesHandling = PreserveReferencesHandling.None;
            jsonSettings.NullValueHandling = NullValueHandling.Ignore;
            jsonSettings.Formatting = Formatting.None;
            jsonSettings.ContractResolver = new DefaultContractResolver();
            return jsonSettings;
        }

        public T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json, _settings);
        }

        T ISerializer.Deserialize<T>(Stream stream)
        {
            if (stream.CanSeek)
            {
                stream.Seek(0, SeekOrigin.Begin);
            }

            using (var reader = new StreamReader(stream))
            {
                string json = reader.ReadToEnd();
                return Deserialize<T>(json);
            }
        }

        public object Deserialize(string json, Type type)
        {
            return JsonConvert.DeserializeObject(json, type, _settings)!;
        }

        public string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj, _settings);
        }

        public string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj, _settings);
        }

        public string Serialize(object obj, Type type)
        {
            return JsonConvert.SerializeObject(obj, type, _settings);
        }
    }
}
