namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/subitem/add 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierSubItemAddRequest : WechatApiRequest, IInferable<ChannelsECLeagueHeadSupplierSubItemAddRequest, ChannelsECLeagueHeadSupplierSubItemAddResponse>
    {
        /// <summary>
        /// 获取或设置计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public long PlanId { get; set; }

        /// <summary>
        /// 获取或设置达人佣金率（范围：0～90）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ratio")]
        [System.Text.Json.Serialization.JsonPropertyName("ratio")]
        public int Ratio { get; set; }
    }
}
