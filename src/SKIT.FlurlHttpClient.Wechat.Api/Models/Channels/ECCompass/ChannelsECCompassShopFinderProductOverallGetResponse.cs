namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/compass/shop/finder/product/overall/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECCompassShopFinderProductOverallGetResponse : WechatApiResponse
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
                /// 获取或设置动销商品数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_product_id_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_product_id_cnt")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int PayProductCount { get; set; }

                /// <summary>
                /// 获取或设置成交退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_refund_gmv")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_refund_gmv")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long PayRefundGMV { get; set; }

                /// <summary>
                /// 获取或设置退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_gmv")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_gmv")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long RefundGMV { get; set; }
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
