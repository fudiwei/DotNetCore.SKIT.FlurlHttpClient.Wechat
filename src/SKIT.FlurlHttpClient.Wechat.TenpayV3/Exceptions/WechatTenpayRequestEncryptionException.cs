using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Exceptions
{
    public class WechatTenpayRequestEncryptionException : WechatTenpayException
    {
        /// <inheritdoc/>
        internal WechatTenpayRequestEncryptionException()
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayRequestEncryptionException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayRequestEncryptionException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
