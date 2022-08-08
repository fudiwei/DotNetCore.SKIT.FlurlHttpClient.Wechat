using System;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Exceptions
{
    public class WechatAdsRequestTimeoutException : WechatAdsException
    {
        /// <inheritdoc/>
        internal WechatAdsRequestTimeoutException()
        {
        }

        /// <inheritdoc/>
        internal WechatAdsRequestTimeoutException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal WechatAdsRequestTimeoutException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
