using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Exceptions
{
    public class WechatOpenAIRequestTimeoutException : WechatOpenAIException
    {
        /// <inheritdoc/>
        internal WechatOpenAIRequestTimeoutException()
        {
        }

        /// <inheritdoc/>
        internal WechatOpenAIRequestTimeoutException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal WechatOpenAIRequestTimeoutException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
