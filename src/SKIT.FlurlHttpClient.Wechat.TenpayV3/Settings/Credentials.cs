using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayClientOptions.MerchantId"/> 的副本。
        /// </summary>
        public string MerchantId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayClientOptions.MerchantV3Secret"/> 的副本。
        /// </summary>
        public string MerchantV3Secret { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayClientOptions.MerchantCertSerialNumber"/> 的副本。
        /// </summary>
        public string MerchantCertSerialNumber { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatTenpayClientOptions.MerchantCertPrivateKey"/> 的副本。
        /// </summary>
        public string MerchantCertPrivateKey { get; }

        internal Credentials(WechatTenpayClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            MerchantId = options.MerchantId;
            MerchantV3Secret = options.MerchantV3Secret;
            MerchantCertSerialNumber = options.MerchantCertSerialNumber;
            MerchantCertPrivateKey = options.MerchantCertPrivateKey;
        }
    }
}
