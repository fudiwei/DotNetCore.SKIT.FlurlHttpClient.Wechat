namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/membercard-open/cards/{card_id}/codes/{code}/confirm 接口的请求。</para>
    /// </summary>
    public class ConfirmMarketingMemberCardOpenCardCodeRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置会员卡 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? CardId { get; set; }

        /// <summary>
        /// 获取或设置会员卡 Code。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Code { get; set; }

        /// <summary>
        /// 获取或设置开卡状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_card_confirm_state")]
        [System.Text.Json.Serialization.JsonPropertyName("user_card_confirm_state")]
        public string? ConfirmState { get; set; }

        /// <summary>
        /// 获取或设置入会失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
        public string? FailReason { get; set; }
    }
}
