namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.transport_get_agent_pos 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-provider/immediateDelivery.onAgentPosQuery.html </para>
    /// </summary>
    public class TransportGetAgentPosEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable
    {
        /// <summary>
        /// 获取或设置商家 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shopid")]
        [System.Text.Json.Serialization.JsonPropertyName("shopid")]
        public string ShopId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_order_id")]
        public string ShopOrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商家门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_no")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_no")]
        public string ShopNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置配送单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string WaybillId { get; set; } = default!;
    }
}
