namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/giftcard/order/refund 接口的请求。</para>
    /// </summary>
    public class CardGiftCardOrderRefundRequest : WechatApiRequest, IInferable<CardGiftCardOrderRefundRequest, CardGiftCardOrderRefundResponse>
    {
        /// <summary>
        /// 获取或设置礼品卡订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;
    }
}
