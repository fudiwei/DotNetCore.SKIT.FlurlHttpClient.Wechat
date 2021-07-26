using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.Api.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="WechatApiClientOptions.AppId"/> 的副本。
        /// </summary>
        public string AppId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatApiClientOptions.AppSecret"/> 的副本。
        /// </summary>
        public string AppSecret { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatApiClientOptions.ImmeDeliveryAppKey"/> 的副本。
        /// </summary>
        public string? ImmeDeliveryAppKey { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatApiClientOptions.ImmeDeliveryAppSecret"/> 的副本。
        /// </summary>
        public string? ImmeDeliveryAppSecret { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatApiClientOptions.MidasAppKey"/> 的副本。
        /// </summary>
        public string? MidasAppKey { get; }

        internal Credentials(WechatApiClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            AppId = options.AppId;
            AppSecret = options.AppSecret;
            ImmeDeliveryAppKey = options.ImmeDeliveryAppKey;
            ImmeDeliveryAppSecret = options.ImmeDeliveryAppSecret;
            MidasAppKey = options.MidasAppKey;
        }
    }
}
