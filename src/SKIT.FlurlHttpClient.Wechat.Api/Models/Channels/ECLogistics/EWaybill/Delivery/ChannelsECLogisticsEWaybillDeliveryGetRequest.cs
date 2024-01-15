namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/ewaybill/biz/delivery/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECLogisticsEWaybillDeliveryGetRequest : WechatApiRequest, IInferable<ChannelsECLogisticsEWaybillDeliveryGetRequest, ChannelsECLogisticsEWaybillDeliveryGetResponse>
    {
        /// <summary>
        /// 获取或设置状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }
    }
}
