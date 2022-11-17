using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Exceptions
{
    public class WechatTenpayBusinessRequestEncryptionException : WechatTenpayBusinessException
    {
        /// <inheritdoc/>
        internal WechatTenpayBusinessRequestEncryptionException()
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayBusinessRequestEncryptionException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal WechatTenpayBusinessRequestEncryptionException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
