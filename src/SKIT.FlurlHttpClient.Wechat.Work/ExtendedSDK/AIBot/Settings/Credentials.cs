namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Settings
{
    public sealed class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="WechatWorkAIBotClientOptions.PushEncodingAESKey"/> 的副本。
        /// </summary>
        public string? PushEncodingAESKey { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatWorkAIBotClientOptions.PushToken"/> 的副本。
        /// </summary>
        public string? PushToken { get; }

        internal Credentials(WechatWorkAIBotClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            PushEncodingAESKey = options.PushEncodingAESKey;
            PushToken = options.PushToken;
        }
    }
}
