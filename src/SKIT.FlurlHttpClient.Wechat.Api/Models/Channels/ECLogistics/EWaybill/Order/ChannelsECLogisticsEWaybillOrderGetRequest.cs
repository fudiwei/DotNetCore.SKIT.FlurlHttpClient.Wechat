namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/ewaybill/biz/order/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECLogisticsEWaybillOrderGetRequest : WechatApiRequest, IInferable<ChannelsECLogisticsEWaybillOrderGetRequest, ChannelsECLogisticsEWaybillOrderGetResponse>
    {
        /// <summary>
        /// 获取或设置电子面单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ewaybill_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ewaybill_order_id")]
        public string EWaybillOrderId { get; set; } = string.Empty;
    }
}
