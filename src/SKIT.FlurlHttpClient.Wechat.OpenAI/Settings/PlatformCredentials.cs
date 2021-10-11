using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Settings
{
    public class PlatformCredentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="WechatOpenAIPlatformClientOptions.AppId"/> 的副本。
        /// </summary>
        public string AppId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatOpenAIPlatformClientOptions.Token"/> 的副本。
        /// </summary>
        public string Token { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatOpenAIPlatformClientOptions.EncodingAESKey"/> 的副本。
        /// </summary>
        public string EncodingAESKey { get; }

        internal PlatformCredentials(WechatOpenAIPlatformClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            AppId = options.AppId;
            Token = options.Token;
            EncodingAESKey = options.EncodingAESKey;
        }
    }
}
