namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/membercard-open/cards/{card_id}/codes/{code}/confirm 接口的响应。</para>
    /// </summary>
    public class ConfirmMarketingMemberCardOpenCardCodeResponse : WechatTenpayResponse
    {
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public override string? ErrorCode
        {
            get { return IsSuccessful() ? null : base.ErrorCode; }
            set { base.ErrorCode = value; }
        }

        /// <summary>
        /// 获取或设置会员卡 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string? CardId { get; set; }

        /// <summary>
        /// 获取或设置会员卡 Code。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Code
        {
            get { return IsSuccessful() ? base.ErrorCode : null; }
            set { base.ErrorCode = value; }
        }

        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200;
        }
    }
}
