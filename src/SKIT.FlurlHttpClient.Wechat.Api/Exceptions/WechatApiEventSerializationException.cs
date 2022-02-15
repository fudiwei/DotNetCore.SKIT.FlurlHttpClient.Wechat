using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Exceptions
{
    public class WechatApiEventSerializationException : WechatApiException
    {
        /// <inheritdoc/>
        internal WechatApiEventSerializationException()
        {
        }

        /// <inheritdoc/>
        internal WechatApiEventSerializationException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal WechatApiEventSerializationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
