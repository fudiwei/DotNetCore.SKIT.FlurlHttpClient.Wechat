using System;
using Flurl.Http.Configuration;

namespace SKIT.FlurlHttpClient.Wechat
{
    /// <summary>
    /// SKIT.FlurlHttpClient.Wechat 客户端配置项。
    /// </summary>
    public sealed class WechatClientSettings
    {
        /// <summary>
        /// 
        /// </summary>
        public TimeSpan? Timeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TimeSpan? ConnectionLeaseTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ISerializer JsonSerializer { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        public ISerializer UrlEncodedSerializer { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        public IHttpClientFactory FlurlHttpClientFactory { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        internal WechatClientSettings()
        {
        }
    }
}
