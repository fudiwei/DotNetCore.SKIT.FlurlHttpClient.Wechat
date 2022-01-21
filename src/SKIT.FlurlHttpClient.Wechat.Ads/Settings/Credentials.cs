using System;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="WechatAdsClientOptions.AgencyId"/> 的副本。
        /// </summary>
        public string AgencyId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatAdsClientOptions.AgencyAppId"/> 的副本。
        /// </summary>
        public string AgencyAppId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatAdsClientOptions.AgencyApiKey"/> 的副本。
        /// </summary>
        public string AgencyApiKey { get; }

        internal Credentials(WechatAdsClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            AgencyId = options.AgencyId;
            AgencyAppId = options.AgencyAppId;
            AgencyApiKey = options.AgencyApiKey;
        }
    }
}
