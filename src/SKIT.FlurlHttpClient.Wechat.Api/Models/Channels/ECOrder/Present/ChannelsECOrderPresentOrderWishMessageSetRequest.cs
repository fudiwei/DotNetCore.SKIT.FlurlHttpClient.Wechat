namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/presentorder/wishmessage/set 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderPresentOrderWishMessageSetRequest : WechatApiRequest, IInferable<ChannelsECOrderPresentOrderWishMessageSetRequest, ChannelsECOrderPresentOrderWishMessageSetResponse>
    {
        /// <summary>
        /// 获取或设置礼物订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("present_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("present_order_id")]
        public string PresentOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置祝福语。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wish_message")]
        [System.Text.Json.Serialization.JsonPropertyName("wish_message")]
        public string WishMessage { get; set; } = string.Empty;
    }
}
