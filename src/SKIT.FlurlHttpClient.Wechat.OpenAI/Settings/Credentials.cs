using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="WechatOpenAIClientOptions.ClientId"/> 的副本。
        /// </summary>
        public string? ClientId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatOpenAIClientOptions.ClientKey"/> 的副本。
        /// </summary>
        public string? ClientKey { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatOpenAIClientOptions.AppId"/> 的副本。
        /// </summary>
        public string? AppId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatOpenAIClientOptions.PushToken"/> 的副本。
        /// </summary>
        public string? PushToken { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatOpenAIClientOptions.PushEncodingAESKey"/> 的副本。
        /// </summary>
        public string? PushEncodingAESKey { get; }

        internal Credentials(WechatOpenAIClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            ClientId = options.ClientId;
            ClientKey = options.ClientKey;
            AppId = options.AppId;
            PushToken = options.PushToken;
            PushEncodingAESKey = options.PushEncodingAESKey;
        }
    }
}
