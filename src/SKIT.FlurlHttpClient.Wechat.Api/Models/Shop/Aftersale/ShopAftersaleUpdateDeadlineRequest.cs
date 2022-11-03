namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/aftersale/update_deadline 接口的请求。</para>
    /// </summary>
    public class ShopAftersaleUpdateDeadlineRequest : WechatApiRequest, IInferable<ShopAftersaleUpdateDeadlineRequest, ShopAftersaleUpdateDeadlineResponse>
    {
        /// <summary>
        /// 获取或设置商家自定义订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_id")]
        public string OutOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置售后截止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sale_deadline")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sale_deadline")]
        public long AftersaleDeadlineTimestamp { get; set; }
    }
}
