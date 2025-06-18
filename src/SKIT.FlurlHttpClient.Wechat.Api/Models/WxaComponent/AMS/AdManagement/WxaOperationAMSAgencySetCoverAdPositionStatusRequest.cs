namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/operationams?action=agency_set_cover_adpos_status 接口的请求。</para>
    /// </summary>
    public class WxaOperationAMSAgencySetCoverAdPositionStatusRequest : WechatApiRequest, IInferable<WxaOperationAMSAgencySetCoverAdPositionStatusRequest, WxaOperationAMSAgencySetCoverAdPositionStatusResponse>
    {
        /// <summary>
        /// 获取或设置开关状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
