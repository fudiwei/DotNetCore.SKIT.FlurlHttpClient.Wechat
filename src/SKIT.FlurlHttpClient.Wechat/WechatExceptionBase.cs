using System;

namespace SKIT.FlurlHttpClient.Wechat
{
    /// <summary>
    /// SKIT.FlurlHttpClient.Wechat 引发的异常基类。
    /// </summary>
    public abstract class WechatExceptionBase : Exception
    {
        /// <inheritdoc/>
        public WechatExceptionBase()
        {
        }

        /// <inheritdoc/>
        public WechatExceptionBase(string message) 
            : base(message)
        {
        }

        /// <inheritdoc/>
        public WechatExceptionBase(string message, Exception innerException) 
            : base(message, innerException)
        {
        }
    }
}
