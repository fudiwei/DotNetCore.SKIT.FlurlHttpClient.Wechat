namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/funds/getfundsflowdetail 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueFundsGetFundsFlowDetailRequest : WechatApiRequest, IInferable<ChannelsECLeagueFundsGetFundsFlowDetailRequest, ChannelsECLeagueFundsGetFundsFlowDetailResponse>
    {
        /// <summary>
        /// 获取或设置资金流水单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("flow_id")]
        [System.Text.Json.Serialization.JsonPropertyName("flow_id")]
        public string FundsFlowId { get; set; } = string.Empty;
    }
}
