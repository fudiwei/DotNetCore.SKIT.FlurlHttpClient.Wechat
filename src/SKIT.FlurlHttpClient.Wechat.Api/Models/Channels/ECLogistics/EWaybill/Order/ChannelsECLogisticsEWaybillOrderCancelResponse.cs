namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/ewaybill/biz/order/cancel 接口的响应。</para>
    /// </summary>
    public class ChannelsECLogisticsEWaybillOrderCancelResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置快递公司错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_error_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_error_msg")]
        public string? DeliveryErrorMessage { get; set; }
    }
}
