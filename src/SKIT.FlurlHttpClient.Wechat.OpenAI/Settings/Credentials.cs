using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="WechatOpenAIClientOptions.AppId"/> 的副本。
        /// </summary>
        public string AppId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatOpenAIClientOptions.Token"/> 的副本。
        /// </summary>
        public string Token { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatOpenAIClientOptions.EncodingAESKey"/> 的副本。
        /// </summary>
        public string EncodingAESKey { get; }

        internal Credentials(WechatOpenAIClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            AppId = options.AppId;
            Token = options.Token;
            EncodingAESKey = options.EncodingAESKey;
        }
    }
}
