namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/windowauth/status/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierWindowAuthStatusGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置授权状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("window_auth_status")]
        [System.Text.Json.Serialization.JsonPropertyName("window_auth_status")]
        public int AuthStatus { get; set; }

        /// <summary>
        /// 获取或设置对应的 OpenFinderId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openfinderid")]
        [System.Text.Json.Serialization.JsonPropertyName("openfinderid")]
        public string? OpenFinderId { get; set; }

        /// <summary>
        /// 获取或设置对应的 OpenTalentId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("opentalentid")]
        [System.Text.Json.Serialization.JsonPropertyName("opentalentid")]
        public string? OpenTalentId { get; set; }
    }
}
