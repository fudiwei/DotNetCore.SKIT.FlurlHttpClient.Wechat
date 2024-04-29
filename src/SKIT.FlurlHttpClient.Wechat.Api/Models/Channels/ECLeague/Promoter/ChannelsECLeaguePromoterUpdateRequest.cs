namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/promoter/upd 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeaguePromoterUpdateRequest : WechatApiRequest, IInferable<ChannelsECLeaguePromoterUpdateRequest, ChannelsECLeaguePromoterUpdateResponse>
    {
        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int OperateType { get; set; }

        /// <summary>
        /// 获取或设置视频号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finder_id")]
        [System.Text.Json.Serialization.JsonPropertyName("finder_id")]
        public string FinderId { get; set; } = string.Empty;
    }
}
