using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample_Net5.Options
{
    public partial class WechatOptions : IOptions<WechatOptions>
    {
        WechatOptions IOptions<WechatOptions>.Value => this;

        public WechatMerchant[] Merchants { get; set; } = Array.Empty<WechatMerchant>();

        public string CallbackEntry { get; set; } = string.Empty;
    }

    partial class WechatOptions
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
