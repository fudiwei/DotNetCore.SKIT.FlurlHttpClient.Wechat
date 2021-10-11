using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Settings
{
    public class ThirdPartyCredentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="WechatOpenAIThirdPartyClientOptions.ClientId"/> 的副本。
        /// </summary>
        public string ClientId { get; } = default!;

        /// <summary>
        /// 初始化客户端时 <see cref="WechatOpenAIThirdPartyClientOptions.ClientKey"/> 的副本。
        /// </summary>
        public string ClientKey { get; } = default!;

        internal ThirdPartyCredentials(WechatOpenAIThirdPartyClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            ClientId = options.ClientId;
            ClientKey = options.ClientKey;
        }
    }
}
