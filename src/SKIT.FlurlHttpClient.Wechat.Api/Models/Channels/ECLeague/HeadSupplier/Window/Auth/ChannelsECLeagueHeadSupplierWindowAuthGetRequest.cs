namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/windowauth/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierWindowAuthGetRequest : WechatApiRequest, IInferable<ChannelsECLeagueHeadSupplierWindowAuthGetRequest, ChannelsECLeagueHeadSupplierWindowAuthGetResponse>
    {
        /// <summary>
        /// 获取或设置视频号 ID。与字段 <see cref="OpenId" />、<see cref="TalentAppId"/> 三选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finder_id")]
        [System.Text.Json.Serialization.JsonPropertyName("finder_id")]
        public string? FinderId { get; set; }

        /// <summary>
        /// 获取或设置用户 OpenId。与字段 <see cref="FinderId" />、<see cref="TalentAppId"/> 三选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置达人平台 AppId。与字段 <see cref="FinderId" />、<see cref="OpenId"/> 三选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("talent_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("talent_appid")]
        public string? TalentAppId { get; set; }
    }
}
