namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/pay/getorderlist 接口的响应。</para>
    /// </summary>
    public class ShopPayGetOrderListResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置商户订单号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_no_list")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_no_list")]
        public string[] OutTradeNumeberList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有下一页。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置下一页分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_index")]
        [System.Text.Json.Serialization.JsonPropertyName("last_index")]
        public string? Offset { get; set; }
    }
}
