using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Exceptions
{
    public class WechatTenpayBusinessRequestTimeoutException : WechatTenpayBusinessException
    {
        /// <inheritdoc/>
        internal WechatTenpayBusinessRequestTimeoutException()
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayBusinessRequestTimeoutException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayBusinessRequestTimeoutException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
