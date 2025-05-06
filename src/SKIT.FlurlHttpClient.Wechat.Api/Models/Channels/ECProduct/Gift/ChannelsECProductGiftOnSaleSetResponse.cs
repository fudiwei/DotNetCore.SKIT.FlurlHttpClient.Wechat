using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/gift/onsale/set 接口的响应。</para>
    /// </summary>
    public class ChannelsECProductGiftOnSaleSetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class SKU
                    {
                        /// <summary>
                        /// 获取或设置原始商品 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("src_sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("src_sku_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long SourceSKUId { get; set; }

                        /// <summary>
                        /// 获取或设置赠品 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("gift_sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("gift_sku_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long GiftSKUId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置原始商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("src_product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("src_product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long SourceProductId { get; set; }

                /// <summary>
                /// 获取或设置赠品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("gift_product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("gift_product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long GiftProductId { get; set; }

                /// <summary>
                /// 获取或设置 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_mappings")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_mappings")]
                public Types.SKU[] SKUList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
