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
        public string FinderId { get; set; } = string.Empty;
    }
}
