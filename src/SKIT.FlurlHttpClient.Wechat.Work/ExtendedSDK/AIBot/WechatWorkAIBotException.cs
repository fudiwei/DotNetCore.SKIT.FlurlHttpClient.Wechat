namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot
{
    /// <summary>
    /// 当调用企业微信智能机器人 API 出错时引发的异常。
    /// </summary>
    public class WechatWorkAIBotException : CommonException
    {
        /// <inheritdoc/>
        public WechatWorkAIBotException()
        {
        }

        /// <inheritdoc/>
        public WechatWorkAIBotException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        public WechatWorkAIBotException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
