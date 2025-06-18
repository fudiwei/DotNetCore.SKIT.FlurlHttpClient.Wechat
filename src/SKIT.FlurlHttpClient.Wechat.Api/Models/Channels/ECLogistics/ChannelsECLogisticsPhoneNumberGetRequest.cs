namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/phonenumber/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECLogisticsPhoneNumberGetRequest : WechatApiRequest, IInferable<ChannelsECLogisticsPhoneNumberGetRequest, ChannelsECLogisticsPhoneNumberGetResponse>
    {
        /// <summary>
        /// 获取或设置运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string WaybillId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置虚拟号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("private_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("private_phone")]
        public string? VirtualPhoneNumber { get; set; }
    }
}
