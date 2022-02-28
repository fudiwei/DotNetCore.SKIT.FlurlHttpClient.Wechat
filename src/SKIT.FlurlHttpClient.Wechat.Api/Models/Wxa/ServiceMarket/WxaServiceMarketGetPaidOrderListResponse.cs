namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/servicemarket/get_paid_order_list 接口的响应。</para>
    /// </summary>
    public class WxaServiceMarketGetPaidOrderListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Order
            {
                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public long OrderId { get; set; }

                /// <summary>
                /// 获取或设置规格 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("specification_id")]
                [System.Text.Json.Serialization.JsonPropertyName("specification_id")]
                public string SpecificationId { get; set; } = default!;

                /// <summary>
                /// 获取或设置生效时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("effective_time")]
                [System.Text.Json.Serialization.JsonPropertyName("effective_time")]
                public long EffectiveTimestamp { get; set; }

                /// <summary>
                /// 获取或设置过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public long ExpireTimestamp { get; set; }

                /// <summary>
                /// 获取或设置订单总价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_price")]
                [System.Text.Json.Serialization.JsonPropertyName("total_price")]
                public int? TotalFee { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_list")]
        public Types.Order[] OrderList { get; set; } = default!;
    }
}
