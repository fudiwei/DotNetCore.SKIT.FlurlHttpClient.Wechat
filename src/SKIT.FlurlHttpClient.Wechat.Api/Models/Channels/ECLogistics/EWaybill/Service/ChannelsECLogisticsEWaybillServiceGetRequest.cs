namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/ewaybill/service/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECLogisticsEWaybillServiceGetRequest : WechatApiRequest, IInferable<ChannelsECLogisticsEWaybillServiceGetRequest, ChannelsECLogisticsEWaybillServiceGetResponse>
    {
        /// <summary>
        /// 获取或设置快递公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_id")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
        public string? DeliveryId { get; set; }

        /// <summary>
        /// 获取或设置快递单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string? WaybillId { get; set; }
    }
}
