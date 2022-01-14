namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/order/rejectrefund 接口的请求。</para>
    /// </summary>
    public class ProductOrderRejectRefundRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置售后单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public long AftersaleOrderId { get; set; }

        /// <summary>
        /// 获取或设置拒绝原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reject_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
        public string RejectReason { get; set; } = string.Empty;
    }
}
