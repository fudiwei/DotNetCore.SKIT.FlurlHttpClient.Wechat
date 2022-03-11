using System;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Exceptions
{
    public class WechatAdsRequestAgencyTokenException : WechatAdsException
    {
        /// <inheritdoc/>
        internal WechatAdsRequestAgencyTokenException()
        {
        }

        /// <inheritdoc/>
        internal WechatAdsRequestAgencyTokenException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal WechatAdsRequestAgencyTokenException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
