using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace SKIT.FlurlHttpClient.Wechat.Api.Sample_Net5.Options
{
    public partial class WechatOptions : IOptions<WechatOptions>
    {
        WechatOptions IOptions<WechatOptions>.Value => this;

        public WechatAccount[] Accounts { get; set; } = Array.Empty<WechatAccount>();

        public string CallbackState { get; set; } = string.Empty;

        public string CallbackToken { get; set; } = string.Empty;
    }

    partial class WechatOptions
    {
        public class WechatAccount
        { 
            public string? GhId { get; set; }

            public string AppId { get; set; } = string.Empty;

            public string AppSecret { get; set; } = string.Empty;
        }
    }
}
