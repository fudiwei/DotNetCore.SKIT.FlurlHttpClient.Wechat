using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.Api.Sample_Net5.Models
{
    public class WechatAccessTokenEntity
    {
        public string AppId { get; set; } = string.Empty;

        public string AccessToken { get; set; } = string.Empty;

        public long ExpireTimestamp { get; set; }

        public long UpdateTimestamp { get; set; }

        public long CreateTimestamp { get; set; }
    }
}
