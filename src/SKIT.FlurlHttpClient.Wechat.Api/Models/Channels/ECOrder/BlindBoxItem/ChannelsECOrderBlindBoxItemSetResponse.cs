namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/blindboxitem/set 接口的响应。</para>
    /// </summary>
    public class ChannelsECOrderBlindBoxItemSetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class FailedItem
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long SKUId { get; set; }

                /// <summary>
                /// 获取或设置商品编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_unique_id")]
                [System.Text.Json.Serialization.JsonPropertyName("item_unique_id")]
                public string? ItemUniqueId { get; set; }

                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errcode")]
                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errmsg")]
                [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                public string? ErrorMessage { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置设置失败的盲盒款式列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_item_list")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_item_list")]
        public List<Types.FailedItem>? FailedItemList { get; set; }
    }
}
