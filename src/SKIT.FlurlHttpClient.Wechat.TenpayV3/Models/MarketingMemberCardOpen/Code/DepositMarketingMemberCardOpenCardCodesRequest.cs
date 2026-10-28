namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/membercard-open/cards/{card_id}/codes/deposit 接口的请求。</para>
    /// </summary>
    public class DepositMarketingMemberCardOpenCardCodesRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置会员卡 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? CardId { get; set; }

        /// <summary>
        /// 获取或设置会员卡 Code 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public List<string>? CodeList { get; set; }
    }
}
