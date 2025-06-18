namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/membercard-open/cards/{card_id}/codes/{code}/activate 接口的请求。</para>
    /// </summary>
    public class ActivateMarketingMemberCardOpenCardCodeRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置会员卡 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CardId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会员卡 Code。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会员编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("membership_number")]
        [System.Text.Json.Serialization.JsonPropertyName("membership_number")]
        public string? MembershipNumber { get; set; }
    }
}
