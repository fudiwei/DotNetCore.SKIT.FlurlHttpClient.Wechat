using System;
using Microsoft.Extensions.Options;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample.Options
{
    public partial class TenpayOptions : IOptions<TenpayOptions>
    {
        TenpayOptions IOptions<TenpayOptions>.Value => this;

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

                public string CertSerialNumber { get; set; } = string.Empty;

                public string CertPrivateKey { get; set; } = string.Empty;
            }
        }
    }
}
