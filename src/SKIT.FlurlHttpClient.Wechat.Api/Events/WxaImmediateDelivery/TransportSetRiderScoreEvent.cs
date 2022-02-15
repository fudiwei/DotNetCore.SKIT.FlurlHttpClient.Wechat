namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.transport_set_rider_score 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-provider/immediateDelivery.onRiderScoreSet.html </para>
    /// </summary>
    public class TransportSetRiderScoreEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable
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

        /// <summary>
        /// 获取或设置配送准时分数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_ontime_score")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_ontime_score")]
        public int DeliveryOntimeScore { get; set; }

        /// <summary>
        /// 获取或设置货物完整分数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cargo_intact_score")]
        [System.Text.Json.Serialization.JsonPropertyName("cargo_intact_score")]
        public int CargoIntactScore { get; set; }

        /// <summary>
        /// 获取或设置服务态度分数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attitude_score")]
        [System.Text.Json.Serialization.JsonPropertyName("attitude_score")]
        public int AttitudeScore { get; set; }
    }
}
