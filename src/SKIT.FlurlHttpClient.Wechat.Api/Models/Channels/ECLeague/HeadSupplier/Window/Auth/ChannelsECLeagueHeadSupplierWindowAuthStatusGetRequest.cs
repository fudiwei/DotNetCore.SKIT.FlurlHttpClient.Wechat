namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/windowauth/status/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierWindowAuthStatusGetRequest : WechatApiRequest, IInferable<ChannelsECLeagueHeadSupplierWindowAuthStatusGetRequest, ChannelsECLeagueHeadSupplierWindowAuthStatusGetResponse>
    {
        /// <summary>
        /// 获取或设置视频号 ID。与字段 <see cref="OpenId" />、<see cref="TalentAppId"/>、<see cref="OpenFinderId"/> 四选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finder_id")]
        [System.Text.Json.Serialization.JsonPropertyName("finder_id")]
        public string? FinderId { get; set; }

        /// <summary>
        /// 获取或设置用户 OpenId。与字段 <see cref="FinderId" />、<see cref="TalentAppId"/>、<see cref="OpenFinderId"/> 四选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置带货达人 OpenFinderId。与字段 <see cref="FinderId" />、<see cref="OpenId"/>、<see cref="TalentAppId"/> 四选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openfinderid")]
        [System.Text.Json.Serialization.JsonPropertyName("openfinderid")]
        public string? OpenFinderId { get; set; }

        /// <summary>
        /// 获取或设置带货达人 AppId。与字段 <see cref="FinderId" />、<see cref="OpenId"/>、<see cref="OpenFinderId"/> 四选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("talent_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("talent_appid")]
        public string? TalentAppId { get; set; }
    }
}
