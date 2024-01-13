namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/ewaybill/biz/template/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECLogisticsEWaybillTemplateGetRequest : WechatApiRequest, IInferable<ChannelsECLogisticsEWaybillTemplateGetRequest, ChannelsECLogisticsEWaybillTemplateGetResponse>
    {
        /// <summary>
        /// 获取或设置快递公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_id")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
        public string? DeliveryId { get; set; }
    }
}
