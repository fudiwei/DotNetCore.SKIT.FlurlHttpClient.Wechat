using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Exceptions
{
    public class WechatTenpayBusinessResponseDecryptionException : WechatTenpayBusinessException
    {
        /// <inheritdoc/>
        internal WechatTenpayBusinessResponseDecryptionException()
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayBusinessResponseDecryptionException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayBusinessResponseDecryptionException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
