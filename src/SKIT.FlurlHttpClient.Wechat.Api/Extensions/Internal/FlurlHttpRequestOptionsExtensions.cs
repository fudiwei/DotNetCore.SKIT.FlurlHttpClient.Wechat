using System;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    internal static class FlurlHttpRequestOptionsExtensions
    {
        public static IFlurlRequest SetOptions(this IFlurlRequest request, WechatApiRequest options)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            if (options == null) throw new ArgumentNullException(nameof(options));

            if (options.Timeout.HasValue)
            {
                request.WithTimeout(TimeSpan.FromMilliseconds(options.Timeout.Value));
            }

            return request;
        }
    }
}
