namespace SKIT.FlurlHttpClient.Wechat.Work.Utilities
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
    }
}
