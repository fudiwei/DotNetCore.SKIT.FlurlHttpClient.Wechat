namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/notify_provide_goods 接口的请求。</para>
    /// </summary>
    public class XPayNotifyProvideGoodsRequest : XPayRequestBase, IInferable<XPayNotifyProvideGoodsRequest, XPayNotifyProvideGoodsResponse>
    {
        /// <summary>
        /// 获取或设置订单号。与字段 <see cref="WxOrderId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置微信内部订单号。与字段 <see cref="OrderId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_order_id")]
        public string? WxOrderId { get; set; }

        protected internal override string GetRequestPath()
        {
            return "/xpay/notify_provide_goods";
        }
    }
}
