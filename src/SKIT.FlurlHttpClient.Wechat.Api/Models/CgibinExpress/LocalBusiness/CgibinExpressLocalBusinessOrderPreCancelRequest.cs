namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/local/business/order/precancel 接口的请求。</para>
    /// </summary>
    public class CgibinExpressLocalBusinessOrderPreCancelRequest : CgibinExpressLocalBusinessRequestBase, IInferable<CgibinExpressLocalBusinessOrderPreCancelRequest, CgibinExpressLocalBusinessOrderPreCancelResponse>
    {
        /// <summary>
        /// 获取或设置商家门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_no")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_no")]
        public string ShopNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置配送公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_id")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
        public string DeliveryId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置配送单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string? WaybillId { get; set; }

        /// <summary>
        /// 获取或设置取消原因 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_reason_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_reason_id")]
        public int CancelReasonId { get; set; }

        /// <summary>
        /// 获取或设置取消原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_reason")]
        public string? CancelReason { get; set; }
    }
}
