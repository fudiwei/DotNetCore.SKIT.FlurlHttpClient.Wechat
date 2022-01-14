namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/spu/search 接口的请求。</para>
    /// </summary>
    public class ProductSPUSearchRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置搜索关键词。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword")]
        [System.Text.Json.Serialization.JsonPropertyName("keyword")]
        public string Keyword { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置指定商品来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source")]
        [System.Text.Json.Serialization.JsonPropertyName("source")]
        public int? Source { get; set; }

        /// <summary>
        /// 获取或设置分页页数（从 1 开始）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int Page { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int Limit { get; set; } = 10;
    }
}
