using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Exceptions
{
    public class WechatTenpayRequestSignatureException : WechatTenpayException
    {
        /// <inheritdoc/>
        internal WechatTenpayRequestSignatureException()
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayRequestSignatureException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayRequestSignatureException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
