namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/compass/shop/finder/overall/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECCompassShopFinderOverallGetResponse : WechatApiResponse
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
                /// 获取或设置动销达人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_sales_finder_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_sales_finder_cnt")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long PaySalesFinderCount { get; set; }

                /// <summary>
                /// 获取或设置动销商品数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_product_id_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_product_id_cnt")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int PayProductCount { get; set; }

                /// <summary>
                /// 获取或设置点击成交转化率（单位：百分数）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("click_to_pay_uv_ratio")]
                [System.Text.Json.Serialization.JsonPropertyName("click_to_pay_uv_ratio")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public decimal ClickToPayUVRatio { get; set; }
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
