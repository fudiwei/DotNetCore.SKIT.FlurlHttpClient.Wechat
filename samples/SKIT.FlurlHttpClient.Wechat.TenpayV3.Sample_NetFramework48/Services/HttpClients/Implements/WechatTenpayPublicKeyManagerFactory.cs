using System;
using System.Collections.Concurrent;
using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample.Services.HttpClients.Implements
{
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings;

    internal partial class WechatTenpayPublicKeyManagerFactory : IWechatTenpayPublicKeyManagerFactory
    {
        private readonly ConcurrentDictionary<string, IPublicKeyManager> _dict;

        public WechatTenpayPublicKeyManagerFactory()
        {
            _dict = new ConcurrentDictionary<string, IPublicKeyManager>();
        }

        public IPublicKeyManager Create(string merchantId)
        {
            // NOTICE:
            //   这里的工厂方法是为了演示多租户而存在的，可根据商户号生成不同的公钥管理器。
            //   如果你的项目只存在唯一一个租户，那么直接注入 `PlatformPublicKeyManager` 即可。

            var tenpayMerchantOptions = Options.TenpayOptions.Instance.Value.Merchants?.FirstOrDefault(e => string.Equals(merchantId, e.MerchantId));
            if (tenpayMerchantOptions == null)
                throw new Exception("未在配置项中找到该 MerchantId 对应的微信商户号。");

            return _dict.GetOrAdd(merchantId, (_) =>
            {
                var manager = new InMemoryPublicKeyManager();
                manager.AddEntry(new PublicKeyEntry(PublicKeyEntry.ALGORITHM_TYPE_RSA, tenpayMerchantOptions.PlatformPublicKeyId, tenpayMerchantOptions.PlatformPublicKey));
                return manager;
            });
        }
    }
}
