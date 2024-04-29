namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/stock/update 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductStockUpdateRequest : WechatApiRequest, IInferable<ChannelsECProductStockUpdateRequest, ChannelsECProductStockUpdateResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置 SKU ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
        public long SKUId { get; set; }

        /// <summary>
        /// 获取或设置修改类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("diff_type")]
        [System.Text.Json.Serialization.JsonPropertyName("diff_type")]
        public int DiffType { get; set; }

        /// <summary>
        /// 获取或设置修改数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("num")]
        [System.Text.Json.Serialization.JsonPropertyName("num")]
        public int DiffCount { get; set; }
    }
}
