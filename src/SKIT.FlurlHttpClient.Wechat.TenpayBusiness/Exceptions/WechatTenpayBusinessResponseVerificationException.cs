using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Exceptions
{
    public class WechatTenpayBusinessResponseVerificationException : WechatTenpayBusinessException
    {
        /// <inheritdoc/>
        internal WechatTenpayBusinessResponseVerificationException()
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayBusinessResponseVerificationException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayBusinessResponseVerificationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
