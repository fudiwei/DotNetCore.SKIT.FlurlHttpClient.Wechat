using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    /// <summary>
    /// 当调用微企付 API 出错时引发的异常。
    /// </summary>
    public class WechatTenpayBusinessException : CommonExceptionBase
    {
        /// <inheritdoc/>
        public WechatTenpayBusinessException()
        {
        }

        /// <inheritdoc/>
        public WechatTenpayBusinessException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        public WechatTenpayBusinessException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
