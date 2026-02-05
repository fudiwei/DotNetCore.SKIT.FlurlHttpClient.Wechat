namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/present/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderPresentGetRequest : WechatApiRequest, IInferable<ChannelsECOrderPresentGetRequest, ChannelsECOrderPresentGetResponse>
    {
        /// <summary>
        /// 获取或设置礼物订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("present_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("present_order_id")]
        public string PresentOrderId { get; set; } = string.Empty;
    }
}
