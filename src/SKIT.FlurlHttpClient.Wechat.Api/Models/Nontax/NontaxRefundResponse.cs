namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /nontax/refund 接口的响应。</para>
    /// </summary>
    public class NontaxRefundResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置退款订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_order_id")]
        public string RefundOrderId { get; set; } = default!;
    }
}
