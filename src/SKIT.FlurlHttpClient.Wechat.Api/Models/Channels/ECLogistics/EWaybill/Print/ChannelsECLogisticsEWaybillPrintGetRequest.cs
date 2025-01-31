namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/ewaybill/biz/print/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECLogisticsEWaybillPrintGetRequest : WechatApiRequest, IInferable<ChannelsECLogisticsEWaybillPrintGetRequest, ChannelsECLogisticsEWaybillPrintGetResponse>
    {
        /// <summary>
        /// 获取或设置电子面单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ewaybill_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ewaybill_order_id")]
        public string EWaybillOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string TemplateId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子单的物流单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_waybill_id")]
        public string? SubWaybillId { get; set; }
    }
}
