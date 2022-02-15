using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Exceptions
{
    public class WechatOpenAIEventSerializationException : WechatOpenAIException
    {
        /// <inheritdoc/>
        internal WechatOpenAIEventSerializationException()
        {
        }

        /// <inheritdoc/>
        internal WechatOpenAIEventSerializationException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal WechatOpenAIEventSerializationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
