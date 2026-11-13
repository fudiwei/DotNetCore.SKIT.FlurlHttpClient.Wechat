namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot
{
    /// <summary>
    /// 一个用于构造 <see cref="WechatWorkAIBotClient"/> 时使用的配置项。
    /// </summary>
    public class WechatWorkAIBotClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置企业微信智能机器人 API 入口点。
        /// <para>默认值：<see cref="WechatWorkAIBotEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoint { get; set; } = WechatWorkAIBotEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置企业微信智能机器人 ID。
        /// </summary>
        public string BotId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置企业微信智能机器人 Secret。
        /// </summary>
        public string BotSecret { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置企业微信服务器推送的 EncodingAESKey。
        /// </summary>
        public string? PushEncodingAESKey { get; set; }

        /// <summary>
        /// 获取或设置企业微信服务器推送的 Token。
        /// </summary>
        public string? PushToken { get; set; }
    }
}
