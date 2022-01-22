using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities
{
    internal static class JsonUtility
    {
        internal static string ParseToSortedQueryString(string json)
        {
            if (string.IsNullOrEmpty(json))
                return string.Empty;

            StringBuilder stringBuilder = new StringBuilder();

            JObject jObject = JsonConvert.DeserializeObject<JObject>(json);
            JProperty[] jProps = jObject.Properties().OrderBy(p => p.Name).ToArray();
            foreach (JProperty jProp in jProps)
            {
                if (jProp.Type == JTokenType.Null)
                {
                    continue;
                }

                if (jProp.Type == JTokenType.String)
                {
                    if (string.IsNullOrEmpty((string)jProp.Value))
                        continue;
                }

                stringBuilder.Append($"{jProp.Name}={jProp.Value}&");
            }

            return stringBuilder.ToString().TrimEnd('&');
        }
    }
}
