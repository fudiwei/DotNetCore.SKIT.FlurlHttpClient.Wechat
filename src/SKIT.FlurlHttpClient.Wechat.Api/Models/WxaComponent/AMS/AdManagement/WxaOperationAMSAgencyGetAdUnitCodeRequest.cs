namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/operationams?action=agency_get_adunit_code 接口的请求。</para>
    /// </summary>
    public class WxaOperationAMSAgencyGetAdUnitCodeRequest : WechatApiRequest, IInferable<WxaOperationAMSAgencyGetAdUnitCodeRequest, WxaOperationAMSAgencyGetAdUnitCodeResponse>
    {
        /// <summary>
        /// 获取或设置广告单元 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_unit_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ad_unit_id")]
        public string AdUnitId { get; set; } = string.Empty;
    }
}
