namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/delivery/single_waybill/evaluate_feedback 接口的请求。</para>
    /// </summary>
    public class CgibinExpressDeliverySingleWaybillEvaluateFeedbackRequest : WechatApiRequest, IInferable<CgibinExpressDeliverySingleWaybillEvaluateFeedbackRequest, CgibinExpressDeliverySingleWaybillEvaluateFeedbackResponse>
    {
        /// <summary>
        /// 获取或设置微信订单 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("token")]
        [System.Text.Json.Serialization.JsonPropertyName("token")]
        public string Token { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string WaybillId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置处理结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public string Result { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置处理结果说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc")]
        [System.Text.Json.Serialization.JsonPropertyName("desc")]
        public string? Description { get; set; }
    }
}
