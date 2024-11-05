namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/store/window/product/reorder 接口的请求。</para>
    /// </summary>
    public class ChannelsECStoreWindowProductReorderRequest : WechatApiRequest, IInferable<ChannelsECStoreWindowProductReorderRequest, ChannelsECStoreWindowProductReorderResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置商品序号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("index_num")]
        [System.Text.Json.Serialization.JsonPropertyName("index_num")]
        public int IndexNumber { get; set; }
    }
}
