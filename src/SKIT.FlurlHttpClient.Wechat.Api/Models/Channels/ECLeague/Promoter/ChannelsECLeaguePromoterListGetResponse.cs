namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/promoter/list/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeaguePromoterListGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置视频号唯一标识列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finder_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("finder_ids")]
        public string[] FinderIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
