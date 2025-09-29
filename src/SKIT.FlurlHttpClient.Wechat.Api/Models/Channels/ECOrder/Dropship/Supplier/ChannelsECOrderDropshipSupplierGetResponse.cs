namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/dropship/supplier/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECOrderDropshipSupplierGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class DropshipOrder
            {
                /// <summary>
                /// 获取或设置商家小店 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
                public string ShopAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商家小店名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_name")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_name")]
                public string ShopName { get; set; } = default!;

                /// <summary>
                /// 获取或设置代发单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ds_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ds_order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string DropshipOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置代发单状态状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置代发单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dropship_order")]
        [System.Text.Json.Serialization.JsonPropertyName("dropship_order")]
        public Types.DropshipOrder DropshipOrder { get; set; } = default!;
    }
}
