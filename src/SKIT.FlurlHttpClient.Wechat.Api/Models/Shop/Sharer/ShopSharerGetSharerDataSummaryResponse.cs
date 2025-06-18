namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/sharer/get_sharer_data_summary 接口的响应。</para>
    /// </summary>
    public class ShopSharerGetSharerDataSummaryResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置分享员有效带货额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmv")]
        [System.Text.Json.Serialization.JsonPropertyName("gmv")]
        public int GMV { get; set; }

        /// <summary>
        /// 获取或设置订单数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_cnt")]
        [System.Text.Json.Serialization.JsonPropertyName("order_cnt")]
        public int OrderCount { get; set; }

        /// <summary>
        /// 获取或设置下单用户数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_cnt")]
        [System.Text.Json.Serialization.JsonPropertyName("user_cnt")]
        public int UserCount { get; set; }
    }
}
