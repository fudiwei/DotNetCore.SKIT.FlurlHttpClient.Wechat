namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/ewaybill/biz/order/batchprint 接口的响应。</para>
    /// </summary>
    public class ChannelsECLogisticsEWaybillOrderBatchPrintResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置成功的电子面单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("succ_ewaybill_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("succ_ewaybill_order_id")]
        public string[]? SuccessfulEWaybillOrderIdList { get; set; }

        /// <summary>
        /// 获取或设置失败的电子面单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_ewaybill_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_ewaybill_order_id")]
        public string[]? FailedEWaybillOrderIdList { get; set; }
    }
}
