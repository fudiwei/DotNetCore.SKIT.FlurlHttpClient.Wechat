namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/funds/getfundsflowdetail 接口的请求。</para>
    /// </summary>
    public class ChannelsECFundsGetFundsFlowDetailRequest : WechatApiRequest, IInferable<ChannelsECFundsGetFundsFlowDetailRequest, ChannelsECFundsGetFundsFlowDetailResponse>
    {
        /// <summary>
        /// 获取或设置流水单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("flow_id")]
        [System.Text.Json.Serialization.JsonPropertyName("flow_id")]
        public string FlowId { get; set; } = string.Empty;
    }
}
