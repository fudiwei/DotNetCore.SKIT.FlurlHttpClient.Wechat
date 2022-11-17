using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Exceptions
{
    public class WechatTenpayRequestTimeoutException : WechatTenpayException
    {
        /// <inheritdoc/>
        internal WechatTenpayRequestTimeoutException()
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayRequestTimeoutException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayRequestTimeoutException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
