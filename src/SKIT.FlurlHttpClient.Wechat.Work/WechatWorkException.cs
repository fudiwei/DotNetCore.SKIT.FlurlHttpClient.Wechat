using System;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    /// <summary>
    /// 当调用企业微信 API 出错时引发的异常。
    /// </summary>
    public class WechatWorkException : CommonExceptionBase
    {
        /// <inheritdoc/>
        public WechatWorkException()
        {
        }

        /// <inheritdoc/>
        public WechatWorkException(string message) 
            : base(message)
        {
        }

        /// <inheritdoc/>
        public WechatWorkException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }
    }
}
