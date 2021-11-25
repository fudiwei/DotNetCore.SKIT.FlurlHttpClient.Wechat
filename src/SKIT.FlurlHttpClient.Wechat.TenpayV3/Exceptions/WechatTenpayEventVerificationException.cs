using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Exceptions
{
    public class WechatTenpayEventVerificationException : WechatTenpayException
    {
        /// <inheritdoc/>
        internal WechatTenpayEventVerificationException()
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayEventVerificationException(string message) 
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayEventVerificationException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }
    }
}
