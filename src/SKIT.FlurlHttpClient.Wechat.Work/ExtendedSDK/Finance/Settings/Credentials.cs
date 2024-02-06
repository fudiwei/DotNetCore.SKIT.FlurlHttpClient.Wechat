using System;

namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.Finance.Settings
{
    public sealed class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="WechatWorkFinanceClientOptions.CorpId"/> 的副本。
        /// </summary>
        public string CorpId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatWorkFinanceClientOptions.SecretKey"/> 的副本。
        /// </summary>
        public string SecretKey { get; }

        internal Credentials(WechatWorkFinanceClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            CorpId = options.CorpId;
            SecretKey = options.SecretKey;
        }
    }
}
