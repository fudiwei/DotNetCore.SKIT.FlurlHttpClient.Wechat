namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/talent/window/product/list/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECTalentWindowProductListGetRequest : WechatApiRequest, IInferable<ChannelsECTalentWindowProductListGetRequest, ChannelsECTalentWindowProductListGetResponse>
    {
        /// <summary>
        /// 获取或设置分页页数。与字段 <see cref="Cursor"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_index")]
        [System.Text.Json.Serialization.JsonPropertyName("page_index")]
        public int? Page { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int Limit { get; set; } = 10;

        /// <summary>
        /// 获取或设置翻页标记。与字段 <see cref="Page"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_buffer")]
        [System.Text.Json.Serialization.JsonPropertyName("last_buffer")]
        public string? Cursor { get; set; }
    }
}
