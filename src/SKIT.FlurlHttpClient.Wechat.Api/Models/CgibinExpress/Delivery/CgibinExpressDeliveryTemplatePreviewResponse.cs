namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/delivery/template/preview 接口的响应。</para>
    /// </summary>
    public class CgibinExpressDeliveryTemplatePreviewResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string WaybillId { get; set; } = default!;

        /// <summary>
        /// 获取或设置渲染后的面单 HTML 内容（已经 Base64 编码）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rendered_waybill_template")]
        [System.Text.Json.Serialization.JsonPropertyName("rendered_waybill_template")]
        public string RenderedWaybillTemplateHtml { get; set; } = default!;
    }
}
