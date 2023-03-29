namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/windowauth/status/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierWindowAuthStatusGetRequest : WechatApiRequest, IInferable<ChannelsECLeagueHeadSupplierWindowAuthStatusGetRequest, ChannelsECLeagueHeadSupplierWindowAuthStatusGetResponse>
    {
        /// <summary>
        /// 获取或设置视频号唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finder_id")]
        [System.Text.Json.Serialization.JsonPropertyName("finder_id")]
        public string FinderId { get; set; } = string.Empty;
    }
}
