namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/promoter/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeaguePromoterGetRequest : WechatApiRequest, IInferable<ChannelsECLeaguePromoterGetRequest, ChannelsECLeaguePromoterGetResponse>
    {
        /// <summary>
        /// 获取或设置视频号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finder_id")]
        [System.Text.Json.Serialization.JsonPropertyName("finder_id")]
        public string? FinderId { get; set; }

        /// <summary>
        /// 获取或设置带货达人 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("talent_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("talent_appid")]
        public string? TalentAppId { get; set; }

        /// <summary>
        /// 获取或设置带货达人搜索关键词。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("talent_search_key")]
        [System.Text.Json.Serialization.JsonPropertyName("talent_search_key")]
        public string? TalentKeyword { get; set; }
    }
}
