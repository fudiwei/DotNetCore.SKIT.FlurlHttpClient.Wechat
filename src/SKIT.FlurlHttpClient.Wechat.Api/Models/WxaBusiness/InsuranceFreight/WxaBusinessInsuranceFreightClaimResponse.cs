namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/insurance_freight/claim 接口的响应。</para>
    /// </summary>
    public class WxaBusinessInsuranceFreightClaimResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置理赔报案号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("report_no")]
        [System.Text.Json.Serialization.JsonPropertyName("report_no")]
        public string ReportNumber { get; set; } = default!;
    }
}
