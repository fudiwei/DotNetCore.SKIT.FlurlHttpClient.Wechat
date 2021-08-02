using System;

namespace SKIT.FlurlHttpClient.Wechat.Work.Exceptions
{
    public class WechatWorkEventSerializationException : WechatWorkException
    {
        /// <inheritdoc/>
        internal WechatWorkEventSerializationException()
        {
        }

        /// <inheritdoc/>
        internal WechatWorkEventSerializationException(string message) 
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal WechatWorkEventSerializationException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }
    }
}
