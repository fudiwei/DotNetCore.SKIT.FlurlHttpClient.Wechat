using System;

namespace SKIT.FlurlHttpClient.Wechat.Work.Exceptions
{
    public class WechatWorkRequestTimeoutException : WechatWorkException
    {
        /// <inheritdoc/>
        internal WechatWorkRequestTimeoutException()
        {
        }

        /// <inheritdoc/>
        internal WechatWorkRequestTimeoutException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal WechatWorkRequestTimeoutException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
