using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Exceptions
{
    public class WechatTenpayBusinessRequestSignatureException : WechatTenpayBusinessException
    {
        /// <inheritdoc/>
        internal WechatTenpayBusinessRequestSignatureException()
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayBusinessRequestSignatureException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayBusinessRequestSignatureException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
