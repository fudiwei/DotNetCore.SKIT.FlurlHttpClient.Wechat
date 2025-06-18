namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/icp/cancel_icp_filing 接口的请求。</para>
    /// </summary>
    public class WxaICPCancelICPFilingRequest : WechatApiRequest, IInferable<WxaICPCancelICPFilingRequest, WxaICPCancelICPFilingResponse>
    {
        /// <summary>
        /// 获取或设置注销类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_type")]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_type")]
        public int CancelType { get; set; }
    }
}
