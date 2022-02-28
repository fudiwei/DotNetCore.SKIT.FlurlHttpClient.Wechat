namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/giftcard/order/batchget 接口的请求。</para>
    /// </summary>
    public class CardGiftCardOrderBatchGetRequest : WechatApiRequest, IInferable<CardGiftCardOrderBatchGetRequest, CardGiftCardOrderBatchGetResponse>
    {
        /// <summary>
        /// 获取或设置查询的时间起点时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_time")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
        public long? BeginTimestamp { get; set; }

        /// <summary>
        /// 获取或设置查询的时间终点时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置排序方式。
        /// <para>默认值：ASC</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sort_type")]
        [System.Text.Json.Serialization.JsonPropertyName("sort_type")]
        public string SortType { get; set; } = "ASC";

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public int Limit { get; set; } = 10;
    }
}
