using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayClientOptions.MerchantId"/> 的副本。
        /// </summary>
        public string MerchantId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayClientOptions.MerchantSecret"/> 的副本。
        /// </summary>
        public string MerchantSecret { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayClientOptions.AppId"/> 的副本。
        /// </summary>
        public string? AppId { get; }

        internal Credentials(WechatTenpayClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            MerchantId = options.MerchantId;
            MerchantSecret = options.MerchantSecret;
            AppId = options.AppId;
        }
    }
}
