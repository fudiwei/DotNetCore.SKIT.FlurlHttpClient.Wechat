namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/presentsuborder/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderPresentSubOrderGetRequest : WechatApiRequest, IInferable<ChannelsECOrderPresentSubOrderGetRequest, ChannelsECOrderPresentSubOrderGetResponse>
    {
        /// <summary>
        /// 获取或设置礼物订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("present_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("present_order_id")]
        public string PresetOrderId { get; set; } = string.Empty;
    }
}
