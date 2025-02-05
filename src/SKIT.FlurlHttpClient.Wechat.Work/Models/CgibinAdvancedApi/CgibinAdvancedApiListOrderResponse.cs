namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/advanced_api/list_order 接口的响应。</para>
    /// </summary>
    public class CgibinAdvancedApiListOrderResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Order
            {
                /// <summary>
                /// 获取或设置订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_type")]
                [System.Text.Json.Serialization.JsonPropertyName("order_type")]
                public int OrderType { get; set; }

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_status")]
                [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                public int OrderStatus { get; set; }

                /// <summary>
                /// 获取或设置下单时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_list")]
        public Types.Order[] OrderList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool HasMore { get; set; }
    }
}
