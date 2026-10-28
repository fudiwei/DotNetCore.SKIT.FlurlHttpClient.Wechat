namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Utilities
{
    internal static class HttpRequestGuard
    {
        public static void AgainstEmptyUrl(string? url)
        {
            if (string.IsNullOrEmpty(url))
                throw new ArgumentException($"Bad request, missing url.");
            if (!Uri.TryCreate(url, UriKind.Absolute, out Uri? uri))
                throw new ArgumentException($"Bad request, invalid url: '{url}'.");
            if (!Uri.UriSchemeHttp.Equals(uri.Scheme, StringComparison.OrdinalIgnoreCase) && !Uri.UriSchemeHttps.Equals(uri.Scheme, StringComparison.OrdinalIgnoreCase))
                throw new ArgumentException($"Bad request, unsupported url scheme: '{url}'.");
        }

        public static void AgainstEmptyPathVariable(string? varValue, string varName)
        {
            if (string.IsNullOrEmpty(varValue))
                throw new ArgumentException($"Bad request, missing path variable: \"{NormalizePathName(varName)}\".");
        }

        public static void AgainstEmptyPathVariable(long? varValue, string varName)
        {
            if (varValue.GetValueOrDefault() == 0)
                throw new ArgumentException($"Bad request, missing path variable: \"{NormalizePathName(varName)}\".");
        }

        private static string NormalizePathName(string segment)
        {
            if (segment is not null && !segment.StartsWith("{") && !segment.EndsWith("}"))
                segment = "{" + segment + "}";
            return segment ?? "{}";
        }
    }
}
