using System;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    /// <summary>
    /// 当调用微信 API 出错时引发的异常。
    /// </summary>
    public class WechatApiException : WechatExceptionBase
    {
        /// <inheritdoc/>
        public WechatApiException()
        {
        }

        /// <inheritdoc/>
        public WechatApiException(string message) 
            : base(message)
        {
        }

        /// <inheritdoc/>
        public WechatApiException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }
    }
}
