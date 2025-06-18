namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/deliverycompanylist/new/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderDeliveryCompanyListNewGetRequest : WechatApiRequest, IInferable<ChannelsECOrderDeliveryCompanyListNewGetRequest, ChannelsECOrderDeliveryCompanyListNewGetResponse>
    {
        /// <summary>
        /// 获取或设置是否仅返回接入电子面单的快递公司。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ewaybill_only")]
        [System.Text.Json.Serialization.JsonPropertyName("ewaybill_only")]
        public bool? IsOnlyEWayBill { get; set; }
    }
}
