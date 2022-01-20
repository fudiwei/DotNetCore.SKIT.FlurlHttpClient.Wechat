namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.transport_add_order 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-provider/immediateDelivery.onOrderAdd.html </para>
    /// </summary>
    public class TransportAddOrderEvent : TransportPreCreateOrderEvent, WechatApiEvent.Serialization.IJsonSerializable
    {
        /// <summary>
        /// 获取或设置微信订单 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_token")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_token")]
        public string Token { get; set; } = default!;
    }
}
