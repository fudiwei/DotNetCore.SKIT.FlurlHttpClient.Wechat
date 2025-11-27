namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/virtualnumber/delay 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderVirtualNumberDelayRequest : WechatApiRequest, IInferable<ChannelsECOrderVirtualNumberDelayRequest, ChannelsECOrderVirtualNumberDelayResponse>
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置已延期次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_delay_times")]
        [System.Text.Json.Serialization.JsonPropertyName("has_delay_times")]
        public int DelayTimes { get; set; }
    }
}
