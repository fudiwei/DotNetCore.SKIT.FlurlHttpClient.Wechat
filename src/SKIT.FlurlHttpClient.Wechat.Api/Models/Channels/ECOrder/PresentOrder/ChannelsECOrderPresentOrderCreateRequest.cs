namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/presentorder/create 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderPresentOrderCreateRequest : WechatApiRequest, IInferable<ChannelsECOrderPresentOrderCreateRequest, ChannelsECOrderPresentOrderCreateResponse>
    {
        public static class Types
        {
            public class AuditItem
            {
                /// <summary>
                /// 获取或设置审核项名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_name")]
                [System.Text.Json.Serialization.JsonPropertyName("item_name")]
                public string ItemName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置审核项值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_value")]
                [System.Text.Json.Serialization.JsonPropertyName("item_value")]
                public string ItemValue { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置请求幂等 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("idempotent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("idempotent_id")]
        public string? IdempotentId { get; set; }

        /// <summary>
        /// 获取或设置活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        public string ActivityId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置合作小店 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
        public string ShopAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置祝福语。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wishmessage")]
        [System.Text.Json.Serialization.JsonPropertyName("wishmessage")]
        public string? WishMessage { get; set; }

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置 SKU ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_id")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public long SKUId { get; set; }
    }
}
