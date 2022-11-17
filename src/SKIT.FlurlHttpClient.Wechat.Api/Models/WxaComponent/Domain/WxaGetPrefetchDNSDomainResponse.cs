namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/get_prefetchdnsdomain 接口的响应。</para>
    /// </summary>
    public class WxaGetPrefetchDNSDomainResponse : WechatApiResponse
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
                public string Url { get; set; } = default!;

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置预解析 DNS 域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prefetch_dns_domain")]
        [System.Text.Json.Serialization.JsonPropertyName("prefetch_dns_domain")]
        public Types.PrefetchDNSDomain[] PrefetchDNSDomainList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总共可配置域名个数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size_limit")]
        [System.Text.Json.Serialization.JsonPropertyName("size_limit")]
        public int SizeLimit { get; set; }
    }
}
