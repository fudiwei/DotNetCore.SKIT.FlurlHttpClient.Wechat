namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/vip/user/experiencevalue/update 接口的请求。</para>
    /// </summary>
    public class ChannelsECVipUserExperienceValueUpdateRequest : WechatApiRequest, IInferable<ChannelsECVipUserExperienceValueUpdateRequest, ChannelsECVipUserExperienceValueUpdateResponse>
    {
        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置经验值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("experience_value")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("experience_value")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int ExperienceValue { get; set; }
    }
}
