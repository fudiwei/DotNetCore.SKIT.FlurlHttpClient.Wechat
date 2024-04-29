namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/sensitiveinfo/decode 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderSensitiveInfoDecodeRequest : WechatApiRequest, IInferable<ChannelsECOrderSensitiveInfoDecodeRequest, ChannelsECOrderSensitiveInfoDecodeResponse>
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;
    }
}
