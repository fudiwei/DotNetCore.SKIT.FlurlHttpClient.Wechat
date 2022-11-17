using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Exceptions
{
    public class WechatApiRequestTimeoutException : WechatApiException
    {
        /// <inheritdoc/>
        internal WechatApiRequestTimeoutException()
        {
        }

        /// <inheritdoc/>
        internal WechatApiRequestTimeoutException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal WechatApiRequestTimeoutException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
