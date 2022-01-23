using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Exceptions
{
    public class WechatTenpayEventDecryptionException : WechatTenpayException
    {
        /// <inheritdoc/>
        internal WechatTenpayEventDecryptionException()
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayEventDecryptionException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayEventDecryptionException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
