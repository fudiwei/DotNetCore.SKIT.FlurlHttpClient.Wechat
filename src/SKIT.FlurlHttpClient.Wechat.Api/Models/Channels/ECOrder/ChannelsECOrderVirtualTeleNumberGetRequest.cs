namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/virtualtelnumber/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderVirtualTeleNumberGetRequest : WechatApiRequest, IInferable<ChannelsECOrderVirtualTeleNumberGetRequest, ChannelsECOrderVirtualTeleNumberGetResponse>
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;
    }
}
