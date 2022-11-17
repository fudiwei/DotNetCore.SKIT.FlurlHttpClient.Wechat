namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/window/product/list/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECWindowProductListGetRequest : WechatApiRequest, IInferable<ChannelsECWindowProductListGetRequest, ChannelsECWindowProductListGetResponse>
    {
        /// <summary>
        /// 获取或设置商品来源店铺的 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置分店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("branch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        public long? BranchId { get; set; }

        /// <summary>
        /// 获取或设置分页页数（从 1 开始）。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_index")]
        [System.Text.Json.Serialization.JsonPropertyName("page_index")]
        public int Page { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int Limit { get; set; } = 10;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_buffer")]
        [System.Text.Json.Serialization.JsonPropertyName("last_buffer")]
        public string? Cursor { get; set; }

        /// <summary>
        /// 获取或设置是否需要返回总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_total_num")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("need_total_num")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? RequireTotalCount { get; set; }
    }
}
