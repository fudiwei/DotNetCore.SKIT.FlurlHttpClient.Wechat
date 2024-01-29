using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 当调用微信智能对话 API 出错时引发的异常。
    /// </summary>
    public class WechatOpenAIException : CommonException
    {
        /// <inheritdoc/>
        public WechatOpenAIException()
        {
        }

        /// <inheritdoc/>
        public WechatOpenAIException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        public WechatOpenAIException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
