namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/virtualnumber/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECLogisticsVirtualNumberGetRequest : WechatApiRequest, IInferable<ChannelsECLogisticsVirtualNumberGetRequest, ChannelsECLogisticsVirtualNumberGetResponse>
    {
        /// <summary>
        /// 获取或设置运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string WaybillId { get; set; } = string.Empty;
    }
}
