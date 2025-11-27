namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/compass/shop/overall/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECCompassShopOverallGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置成交金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_gmv")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_gmv")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long PayGMV { get; set; }

                /// <summary>
                /// 获取或设置成交人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_uv")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_uv")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int PayUV { get; set; }

                /// <summary>
                /// 获取或设置成交退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_refund_gmv")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_refund_gmv")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long PayRefundGMV { get; set; }

                /// <summary>
                /// 获取或设置成交订单数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_order_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_order_cnt")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int PayOrderCount { get; set; }

                /// <summary>
                /// 获取或设置直播成交金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_pay_gmv")]
                [System.Text.Json.Serialization.JsonPropertyName("live_pay_gmv")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long LivePayGMV { get; set; }

                /// <summary>
                /// 获取或设置短视频成交金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("feed_pay_gmv")]
                [System.Text.Json.Serialization.JsonPropertyName("feed_pay_gmv")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long FeedPayGMV { get; set; }

                /// <summary>
                /// 获取或设置商品点击人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_click_uv")]
                [System.Text.Json.Serialization.JsonPropertyName("product_click_uv")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int ProductClickUV { get; set; }
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
