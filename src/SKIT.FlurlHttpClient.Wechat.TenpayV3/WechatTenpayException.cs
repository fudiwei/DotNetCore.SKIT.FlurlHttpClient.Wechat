using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 当调用微信支付 API 出错时引发的异常。
    /// </summary>
    public class WechatTenpayException : CommonExceptionBase
    {
        /// <inheritdoc/>
        public WechatTenpayException()
        {
        }

        /// <inheritdoc/>
        public WechatTenpayException(string message) 
            : base(message)
        {
        }

        /// <inheritdoc/>
        public WechatTenpayException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }
    }
}
