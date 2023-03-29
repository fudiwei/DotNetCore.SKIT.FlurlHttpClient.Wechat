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
    }
}
