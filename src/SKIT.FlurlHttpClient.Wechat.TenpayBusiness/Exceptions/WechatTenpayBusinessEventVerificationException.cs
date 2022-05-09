using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Exceptions
{
    public class WechatTenpayBusinessEventVerificationException : WechatTenpayBusinessException
    {
        /// <inheritdoc/>
        internal WechatTenpayBusinessEventVerificationException()
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayBusinessEventVerificationException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayBusinessEventVerificationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
