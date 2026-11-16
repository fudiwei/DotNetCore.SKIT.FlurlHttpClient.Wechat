namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/ewaybill/collection/update 接口的请求。</para>
    /// </summary>
    public class ChannelsECLogisticsEWaybillCollectionUpdateRequest : WechatApiRequest, IInferable<ChannelsECLogisticsEWaybillCollectionUpdateRequest, ChannelsECLogisticsEWaybillCollectionUpdateResponse>
    {
        /// <summary>
        /// 获取或设置快递公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_id")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
        public string? DeliveryId { get; set; }

        /// <summary>
        /// 获取或设置快递单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string? WaybillId { get; set; }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long? ProductId { get; set; }

        /// <summary>
        /// 获取或设置 SKU ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
        public long? SKUId { get; set; }

        /// <summary>
        /// 获取或设置设备 SN 码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sn_code")]
        [System.Text.Json.Serialization.JsonPropertyName("sn_code")]
        public string? SNCode { get; set; }

        /// <summary>
        /// 获取或设置设备 IMEI1 码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("imei1_code")]
        [System.Text.Json.Serialization.JsonPropertyName("imei1_code")]
        public string? IMEI1Code { get; set; }

        /// <summary>
        /// 获取或设置设备 IMEI2 码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("imei2_code")]
        [System.Text.Json.Serialization.JsonPropertyName("imei2_code")]
        public string? IMEI2Code { get; set; }
    }
}
