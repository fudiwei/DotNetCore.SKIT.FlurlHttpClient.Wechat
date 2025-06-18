namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/compass/finder/overall/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECCompassFinderOverallGetResponse : WechatApiResponse
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
                /// 获取或设置橱窗支付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("window_pay_gmv")]
                [System.Text.Json.Serialization.JsonPropertyName("window_pay_gmv")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long WindowPayGMV { get; set; }

                /// <summary>
                /// 获取或设置商品分享支付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_pay_gmv")]
                [System.Text.Json.Serialization.JsonPropertyName("product_pay_gmv")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ProductPayGMV { get; set; }

                /// <summary>
                /// 获取或设置其他渠道支付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("other_pay_gmv")]
                [System.Text.Json.Serialization.JsonPropertyName("other_pay_gmv")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long OtherPayGMV { get; set; }
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
