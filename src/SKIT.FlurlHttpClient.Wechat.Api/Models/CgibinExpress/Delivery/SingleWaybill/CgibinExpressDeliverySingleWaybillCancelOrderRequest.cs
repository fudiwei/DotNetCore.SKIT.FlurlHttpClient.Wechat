namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/delivery/single_waybill/cancel_order 接口的请求。</para>
    /// </summary>
    public class CgibinExpressDeliverySingleWaybillCancelOrderRequest : WechatApiRequest, IInferable<CgibinExpressDeliverySingleWaybillCancelOrderRequest, CgibinExpressDeliverySingleWaybillCancelOrderResponse>
    {
        /// <summary>
        /// 获取或设置微信订单 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("token")]
        [System.Text.Json.Serialization.JsonPropertyName("token")]
        public string Token { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置取消原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string Reason { get; set; } = string.Empty;
    }
}
