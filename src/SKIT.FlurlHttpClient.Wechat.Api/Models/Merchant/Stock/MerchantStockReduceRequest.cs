namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/stock/reduce 接口的请求。</para>
    /// </summary>
    public class MerchantStockReduceRequest : WechatApiRequest, IMapResponse<MerchantStockReduceRequest, MerchantStockReduceResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public string ProductId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 SKU 信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_info")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_info")]
        public string SKUInformation { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置减少的库存数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quantity")]
        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public int Quantity { get; set; }
    }
}
