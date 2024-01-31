using System;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    /// <summary>
    /// 当调用企业微信会话内容存档 API 出错时引发的异常。
    /// </summary>
    public class WechatWorkFinanceException : WechatWorkException
    {
        /// <inheritdoc/>
        public WechatWorkFinanceException()
        {
        }

        /// <inheritdoc/>
        public WechatWorkFinanceException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        public WechatWorkFinanceException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
