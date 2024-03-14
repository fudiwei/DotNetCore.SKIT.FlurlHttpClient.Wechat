using System;

namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.SpecialApi
{
    /// <summary>
    /// 当调用企业微信数据分析专区 API 出错时引发的异常。
    /// </summary>
    public class WechatWorkSpecialApiException : WechatWorkException
    {
        /// <inheritdoc/>
        public WechatWorkSpecialApiException()
        {
        }

        /// <inheritdoc/>
        public WechatWorkSpecialApiException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        public WechatWorkSpecialApiException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
