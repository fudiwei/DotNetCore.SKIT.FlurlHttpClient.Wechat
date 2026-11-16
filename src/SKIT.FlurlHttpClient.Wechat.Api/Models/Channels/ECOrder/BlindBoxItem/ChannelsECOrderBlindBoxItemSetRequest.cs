namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/blindboxitem/set 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderBlindBoxItemSetRequest : WechatApiRequest, IInferable<ChannelsECOrderBlindBoxItemSetRequest, ChannelsECOrderBlindBoxItemSetResponse>
    {
        public static class Types
        {
            public class Item
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_id")]
                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
                public long SKUId { get; set; }

                /// <summary>
                /// 获取或设置商品编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_unique_id")]
                [System.Text.Json.Serialization.JsonPropertyName("item_unique_id")]
                public string? ItemUniqueId { get; set; }

                /// <summary>
                /// 获取或设置盲盒款式 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("blind_box_item_id")]
                [System.Text.Json.Serialization.JsonPropertyName("blind_box_item_id")]
                public string? BlindBoxItemId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置盲盒款式列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_list")]
        [System.Text.Json.Serialization.JsonPropertyName("item_list")]
        public List<Types.Item>? ItemList { get; set; }
    }
}
