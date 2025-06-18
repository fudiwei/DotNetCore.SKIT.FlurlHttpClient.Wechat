using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/set_prefetchdnsdomain 接口的请求。</para>
    /// </summary>
    public class WxaSetPrefetchDNSDomainRequest : WechatApiRequest, IInferable<WxaSetPrefetchDNSDomainRequest, WxaSetPrefetchDNSDomainResponse>
    {
        public static class Types
        {
            public class PrefetchDNSDomain
            {
                /// <summary>
                /// 获取或设置地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string Url { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置预解析 DNS 域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prefetch_dns_domain")]
        [System.Text.Json.Serialization.JsonPropertyName("prefetch_dns_domain")]
        public IList<Types.PrefetchDNSDomain> PrefetchDNSDomainList { get; set; } = new List<Types.PrefetchDNSDomain>();
    }
}
