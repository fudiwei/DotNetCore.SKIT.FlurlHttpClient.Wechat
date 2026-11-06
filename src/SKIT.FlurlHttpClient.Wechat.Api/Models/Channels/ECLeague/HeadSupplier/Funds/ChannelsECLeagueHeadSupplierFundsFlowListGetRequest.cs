namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/funds/flowlist/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierFundsFlowListGetRequest : ChannelsECFundsGetFundsFlowListRequest, IInferable<ChannelsECLeagueHeadSupplierFundsFlowListGetRequest, ChannelsECLeagueHeadSupplierFundsFlowListGetResponse>
    {
        /// <summary>
        /// 获取或设置资金类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("funds_type")]
        [System.Text.Json.Serialization.JsonPropertyName("funds_type")]
        public int? FundsType { get; set; }
    }
}
