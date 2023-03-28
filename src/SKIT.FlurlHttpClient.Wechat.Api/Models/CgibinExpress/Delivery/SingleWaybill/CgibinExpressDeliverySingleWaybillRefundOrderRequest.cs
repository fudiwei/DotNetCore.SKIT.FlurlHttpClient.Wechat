namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/delivery/single_waybill/refund_order 接口的请求。</para>
    /// </summary>
    public class CgibinExpressDeliverySingleWaybillRefundOrderRequest : WechatApiRequest, IInferable<CgibinExpressDeliverySingleWaybillRefundOrderRequest, CgibinExpressDeliverySingleWaybillRefundOrderResponse>
    {
        /// <summary>
        /// 获取或设置微信订单 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("token")]
        [System.Text.Json.Serialization.JsonPropertyName("token")]
        public string Token { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置退款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fee")]
        [System.Text.Json.Serialization.JsonPropertyName("fee")]
        public int RefundFee { get; set; }
    }
}
