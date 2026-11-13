namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/order/opspecialorder 接口的请求。</para>
    /// </summary>
    public class WxaSecOrderOperateSpecialOrderRequest : WechatApiRequest, IInferable<WxaSecOrderOperateSpecialOrderRequest, WxaSecOrderOperateSpecialOrderResponse>
    {
        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int OperateType { get; set; }

        /// <summary>
        /// 获取或设置预计发货时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delay_to")]
        [System.Text.Json.Serialization.JsonPropertyName("delay_to")]
        public long? DelayToTimestamp { get; set; }
    }
}
