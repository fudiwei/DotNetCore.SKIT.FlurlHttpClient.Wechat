namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/paytool/open_order 接口的响应。</para>
    /// </summary>
    public class CgibinPayToolOpenOrderResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置收款订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置收款订单链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_url")]
        [System.Text.Json.Serialization.JsonPropertyName("order_url")]
        public string OrderUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置原价（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("origin_price")]
        [System.Text.Json.Serialization.JsonPropertyName("origin_price")]
        public int? OriginPrice { get; set; }

        /// <summary>
        /// 获取或设置现价（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paid_price")]
        [System.Text.Json.Serialization.JsonPropertyName("paid_price")]
        public int? PaidPrice { get; set; }
    }
}
