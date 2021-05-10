using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Exceptions
{
    public class WechatTenpayResponseDecryptionException : WechatTenpayException
    {
        /// <inheritdoc/>
        internal WechatTenpayResponseDecryptionException()
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayResponseDecryptionException(string message) 
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayResponseDecryptionException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }
    }
}
