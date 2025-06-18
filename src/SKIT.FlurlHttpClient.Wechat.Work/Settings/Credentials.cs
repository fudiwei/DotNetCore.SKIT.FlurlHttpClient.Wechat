using System;

namespace SKIT.FlurlHttpClient.Wechat.Work.Settings
{
    public sealed class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="WechatWorkClientOptions.CorpId"/> 的副本。
        /// </summary>
        public string CorpId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatWorkClientOptions.AgentId"/> 的副本。
        /// </summary>
        public int? AgentId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatWorkClientOptions.AgentSecret"/> 的副本。
        /// </summary>
        public string? AgentSecret { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatWorkClientOptions.ProviderSecret"/> 的副本。
        /// </summary>
        public string? ProviderSecret { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatWorkClientOptions.SuiteId"/> 的副本。
        /// </summary>
        public string? SuiteId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatWorkClientOptions.SuiteId"/> 的副本。
        /// </summary>
        public string? SuiteSecret { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatWorkClientOptions.ModelId"/> 的副本。
        /// </summary>
        public string? ModelId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatWorkClientOptions.SuiteId"/> 的副本。
        /// </summary>
        public string? ModelSecret { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatWorkClientOptions.PushEncodingAESKey"/> 的副本。
        /// </summary>
        public string? PushEncodingAESKey { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatWorkClientOptions.PushToken"/> 的副本。
        /// </summary>
        public string? PushToken { get; }

        internal Credentials(WechatWorkClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            CorpId = options.CorpId;
            AgentId = options.AgentId;
            AgentSecret = options.AgentSecret;
            ProviderSecret = options.ProviderSecret;
            SuiteId = options.SuiteId;
            SuiteSecret = options.SuiteSecret;
            ModelId = options.ModelId;
            ModelSecret = options.ModelSecret;
            PushEncodingAESKey = options.PushEncodingAESKey;
            PushToken = options.PushToken;
        }
    }
}
