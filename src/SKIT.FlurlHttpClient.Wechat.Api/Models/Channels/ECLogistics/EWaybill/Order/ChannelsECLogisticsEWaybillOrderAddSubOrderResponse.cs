namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/ewaybill/biz/order/addsuborder 接口的响应。</para>
    /// </summary>
    public class ChannelsECLogisticsEWaybillOrderAddSubOrderResponse : WechatApiResponse
    {
        public static class Types
        {
            public class SubWaybill : ChannelsECLogisticsEWaybillOrderCreateResponse.Types.SubWaybill
            {
            }
        }

        /// <summary>
        /// 获取或设置电子面单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ewaybill_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ewaybill_order_id")]
        public string? EWaybillOrderId { get; set; }

        /// <summary>
        /// 获取或设置快递单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string? WaybillId { get; set; }

        /// <summary>
        /// 获取或设置快递公司错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_error_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_error_msg")]
        public string? DeliveryErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置打印报文信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("print_info")]
        [System.Text.Json.Serialization.JsonPropertyName("print_info")]
        public string? PrintInfo { get; set; }

        /// <summary>
        /// 获取或设置子单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id_list")]
        public Types.SubWaybill[]? SubWaybillList { get; set; }
    }
}
