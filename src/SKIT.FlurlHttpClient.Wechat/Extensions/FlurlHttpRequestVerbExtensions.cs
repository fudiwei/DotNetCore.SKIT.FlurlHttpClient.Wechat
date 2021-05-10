using System;
using System.Net.Http;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat
{
    public static class FlurlHttpRequestVerbExtensions
    {
        public static IFlurlRequest WithVerb(this string url, string method)
        {
            return WithVerb(url, new HttpMethod(method));
        }

        public static IFlurlRequest WithVerb(this string url, HttpMethod method)
        {
            return WithVerb(Url.Parse(url), method);
        }

        public static IFlurlRequest WithVerb(this Url url, string method)
        {
            return WithVerb(url, new HttpMethod(method));
        }

        public static IFlurlRequest WithVerb(this Url url, HttpMethod method)
        {
            return WithVerb(new FlurlRequest(url), method);
        }

        public static IFlurlRequest WithVerb(this IFlurlRequest request, string method)
        {
            return WithVerb(request, new HttpMethod(method));
        }

        public static IFlurlRequest WithVerb(this IFlurlRequest request, HttpMethod method)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            request.Verb = method;
            return request;
        }
    }
}
