using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Configuration;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample.Options
{
    public partial class TenpayOptions
    {
        public static readonly Lazy<TenpayOptions> Instance = new Lazy<TenpayOptions>(() =>
        {
            var configMerchantRegex = new Regex("^TenpayOptions_Merchant_(\\d+)_MerchantId$");
            var configMerchantIndexes = WebConfigurationManager.AppSettings.AllKeys
                .Where(key => configMerchantRegex.IsMatch(key))
                .Select(key => configMerchantRegex.Matches(key)[0].Groups[1].Value)
                .ToArray();

            return new TenpayOptions()
            {
                Merchants = configMerchantIndexes
                    .Select(i => new Types.WechatMerchant()
                    {
                        MerchantId = WebConfigurationManager.AppSettings[$"TenpayOptions_Merchant_{i}_MerchantId"],
                        SecretV3 = WebConfigurationManager.AppSettings[$"TenpayOptions_Merchant_{i}_SecretV3"],
                        CertificateSerialNumber = WebConfigurationManager.AppSettings[$"TenpayOptions_Merchant_{i}_CertificateSerialNumber"],
                        CertificatePrivateKey = WebConfigurationManager.AppSettings[$"TenpayOptions_Merchant_{i}_CertificatePrivateKey"],
                        PlatformPublicKeyId = WebConfigurationManager.AppSettings[$"TenpayOptions_Merchant_{i}_PlatformPublicKeyId"],
                        PlatformPublicKey = WebConfigurationManager.AppSettings[$"TenpayOptions_Merchant_{i}_PlatformPublicKey"],
                    })
                    .ToArray(),
                NotifyUrl = WebConfigurationManager.AppSettings[$"TenpayOptions_NotifyUrl"]
            };
        }, isThreadSafe: true);
    }

    public partial class TenpayOptions
    {
        public Types.WechatMerchant[] Merchants { get; set; } = Array.Empty<Types.WechatMerchant>();

        public string NotifyUrl { get; set; } = string.Empty;
    }

    public partial class TenpayOptions
    {
        public static class Types
        {
            public class WechatMerchant
            {
                public string MerchantId { get; set; } = string.Empty;

                public string SecretV3 { get; set; } = string.Empty;

                public string CertificateSerialNumber { get; set; } = string.Empty;

                public string CertificatePrivateKey { get; set; } = string.Empty;

                public string PlatformPublicKeyId { get; set; }

                public string PlatformPublicKey { get; set; }
            }
        }
    }
}
