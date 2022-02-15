using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Exceptions
{
    public class WechatTenpayResponseVerificationException : WechatTenpayException
    {
        /// <inheritdoc/>
        internal WechatTenpayResponseVerificationException()
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayResponseVerificationException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayResponseVerificationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
