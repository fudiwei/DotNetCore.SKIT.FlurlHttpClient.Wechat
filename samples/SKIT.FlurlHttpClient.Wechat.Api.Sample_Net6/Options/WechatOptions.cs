using System;
using Microsoft.Extensions.Options;

namespace SKIT.FlurlHttpClient.Wechat.Api.Sample.Options
{
    public partial class WechatOptions : IOptions<WechatOptions>
    {
        WechatOptions IOptions<WechatOptions>.Value => this;

        public Types.WechatAccount[] Accounts { get; set; } = Array.Empty<Types.WechatAccount>();

        public string CallbackState { get; set; } = string.Empty;

        public string CallbackToken { get; set; } = string.Empty;
    }

    public partial class WechatOptions
    {
        public static class Types
        {
            public class WechatAccount
            {
                public string? GhId { get; set; }

                public string AppId { get; set; } = string.Empty;

                public string AppSecret { get; set; } = string.Empty;
            }
        }
    }
}
