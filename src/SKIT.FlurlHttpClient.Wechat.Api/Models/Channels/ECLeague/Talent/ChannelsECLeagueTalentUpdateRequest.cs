namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/talent/update 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueTalentUpdateRequest : WechatApiRequest, IInferable<ChannelsECLeagueTalentUpdateRequest, ChannelsECLeagueTalentUpdateResponse>
    {
        /// <summary>
        /// 获取或设置带货达人 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("talent_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("talent_appid")]
        public string TalentAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upd_talent_type")]
        [System.Text.Json.Serialization.JsonPropertyName("upd_talent_type")]
        public int UpdateType { get; set; }
    }
}
