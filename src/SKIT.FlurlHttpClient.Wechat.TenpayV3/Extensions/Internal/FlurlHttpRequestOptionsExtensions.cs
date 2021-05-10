using System;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    internal static class FlurlHttpRequestOptionsExtensions
    {
        public static IFlurlRequest SetOptions(this IFlurlRequest request, WechatTenpayRequest options)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            if (options == null) throw new ArgumentNullException(nameof(options));

            if (options.Timeout.HasValue)
            {
                request.WithTimeout(TimeSpan.FromMilliseconds(options.Timeout.Value));
            }

            if (options.WechatpayCertSerialNumber != null)
            {
                request.Headers.Remove("Wechatpay-Serial");
                request.WithHeader("Wechatpay-Serial", options.WechatpayCertSerialNumber);
            }

            return request;
        }
    }
}
