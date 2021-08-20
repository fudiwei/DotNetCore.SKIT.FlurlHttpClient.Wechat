using System;

namespace SKIT.FlurlHttpClient.Wechat.Ads
{
    /// <summary>
    /// 微信广告平台 API 出错时引发的异常。
    /// </summary>
    public class WechatAdsException : CommonExceptionBase
    {
        /// <inheritdoc/>
        public WechatAdsException()
        {
        }

        /// <inheritdoc/>
        public WechatAdsException(string message) 
            : base(message)
        {
        }

        /// <inheritdoc/>
        public WechatAdsException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }
    }
}
