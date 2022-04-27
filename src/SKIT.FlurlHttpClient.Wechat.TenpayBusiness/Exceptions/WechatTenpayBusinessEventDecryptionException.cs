using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Exceptions
{
    public class WechatTenpayBusinessEventDecryptionException : WechatTenpayBusinessException
    {
        /// <inheritdoc/>
        internal WechatTenpayBusinessEventDecryptionException()
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayBusinessEventDecryptionException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayBusinessEventDecryptionException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
