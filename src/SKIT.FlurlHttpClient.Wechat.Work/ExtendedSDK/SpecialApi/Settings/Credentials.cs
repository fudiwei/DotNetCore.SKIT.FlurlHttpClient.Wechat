using System;

namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.SpecialApi.Settings
{
    public sealed class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="WechatWorkSpecialApiClientOptions.ProviderCorpId"/> 的副本。
        /// </summary>
        public string ProviderCorpId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatWorkSpecialApiClientOptions.SpecialSecret"/> 的副本。
        /// </summary>
        public string SpecialSecret { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatWorkSpecialApiClientOptions.SignSecret"/> 的副本。
        /// </summary>
        public string SignSecret { get; }

        internal Credentials(WechatWorkSpecialApiClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            ProviderCorpId = options.ProviderCorpId;
            SpecialSecret = options.SpecialSecret;
            SignSecret = options.SignSecret;
        }
    }
}
