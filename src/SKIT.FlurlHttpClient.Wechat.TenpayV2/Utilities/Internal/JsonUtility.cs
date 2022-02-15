using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities
{
    internal static class JsonUtility
    {
        internal static string ParseToSortedQueryString(string json)
        {
            if (string.IsNullOrEmpty(json))
                return string.Empty;

            StringBuilder stringBuilder = new StringBuilder();
            JsonObject jObject = JsonNode.Parse(json)!.AsObject();
            foreach (KeyValuePair<string, JsonNode?> jProp in jObject.OrderBy(p => p.Key))
            {
                string key = jProp.Key;
                string? value = jProp.Value?.ToString();
                if (string.IsNullOrEmpty(value))
                    continue;

                stringBuilder.Append($"{key}={value}&");
            }

            return stringBuilder.ToString().TrimEnd('&');
        }
    }
}
