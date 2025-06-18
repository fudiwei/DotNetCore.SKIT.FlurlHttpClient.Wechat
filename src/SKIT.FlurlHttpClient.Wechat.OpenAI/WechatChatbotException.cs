using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 当调用微信智能对话 API 出错时引发的异常。
    /// </summary>
    public class WechatChatbotException : CommonException
    {
        /// <inheritdoc/>
        public WechatChatbotException()
        {
        }

        /// <inheritdoc/>
        public WechatChatbotException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        public WechatChatbotException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
