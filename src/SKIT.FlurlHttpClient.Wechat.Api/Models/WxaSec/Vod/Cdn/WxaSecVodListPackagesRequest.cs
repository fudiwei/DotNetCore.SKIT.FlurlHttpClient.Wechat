namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/listpackages 接口的请求。</para>
    /// </summary>
    public class WxaSecVodListPackagesRequest : WechatApiRequest, IInferable<WxaSecVodListPackagesRequest, WxaSecVodListPackagesResponse>
    {
        /// <summary>
        /// 获取或设置流量包状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置查询类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_type")]
        [System.Text.Json.Serialization.JsonPropertyName("query_type")]
        public int? QueryType { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：100</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; } = 100;
    }
}
