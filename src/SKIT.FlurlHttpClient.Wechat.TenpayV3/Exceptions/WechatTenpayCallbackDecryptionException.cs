using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Exceptions
{
    public class WechatTenpayCallbackDecryptionException : WechatTenpayException
    {
        /// <inheritdoc/>
        internal WechatTenpayCallbackDecryptionException()
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayCallbackDecryptionException(string message) 
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayCallbackDecryptionException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }
    }
}
