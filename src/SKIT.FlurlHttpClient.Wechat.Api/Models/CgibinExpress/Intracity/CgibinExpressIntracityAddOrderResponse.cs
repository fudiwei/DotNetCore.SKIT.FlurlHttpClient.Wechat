namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/intracity/addorder 接口的响应。</para>
    /// </summary>
    public class CgibinExpressIntracityAddOrderResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置微信门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_store_id")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_store_id")]
        public string StoreId { get; set; } = default!;

        /// <summary>
        /// 获取或设置门店订单编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("store_order_id")]
        public string StoreOrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_order_id")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置运力 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_trans_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_trans_id")]
        public string ServiceTransId { get; set; } = default!;

        /// <summary>
        /// 获取或设置运力订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trans_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("trans_order_id")]
        public string TransOrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置运力配送单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string? WaybillId { get; set; }

        /// <summary>
        /// 获取或设置配送距离（单位：米）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distance")]
        [System.Text.Json.Serialization.JsonPropertyName("distance")]
        public int Distance { get; set; }

        /// <summary>
        /// 获取或设置配送费（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fee")]
        [System.Text.Json.Serialization.JsonPropertyName("fee")]
        public int Fee { get; set; }

        /// <summary>
        /// 获取或设置取货码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fetch_code")]
        [System.Text.Json.Serialization.JsonPropertyName("fetch_code")]
        public string? FetchCode { get; set; }

        /// <summary>
        /// 获取或设置订单序号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_seq")]
        [System.Text.Json.Serialization.JsonPropertyName("order_seq")]
        public string? OrderSequence { get; set; }
    }
}
