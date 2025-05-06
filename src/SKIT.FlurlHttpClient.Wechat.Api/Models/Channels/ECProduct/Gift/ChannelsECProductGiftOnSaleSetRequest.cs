using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/gift/onsale/set 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductGiftOnSaleSetRequest : WechatApiRequest, IInferable<ChannelsECProductGiftOnSaleSetRequest, ChannelsECProductGiftOnSaleSetResponse>
    {
        public static class Types
        {
            public class SKU
            {
                /// <summary>
                /// 获取或设置原始 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                public long? SKUId { get; set; }

                /// <summary>
                /// 获取或设置库存。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_num")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_num")]
                public int? Stock { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置原始商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置 SKU 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skus")]
        [System.Text.Json.Serialization.JsonPropertyName("skus")]
        public IList<Types.SKU>? SKUList { get; set; }
    }
}
