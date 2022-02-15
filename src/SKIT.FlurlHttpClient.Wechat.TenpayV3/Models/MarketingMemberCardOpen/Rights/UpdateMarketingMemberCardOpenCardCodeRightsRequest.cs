namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /marketing/membercard-open/cards/{card_id}/codes/{code}/rights 接口的请求。</para>
    /// </summary>
    public class UpdateMarketingMemberCardOpenCardCodeRightsRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Guide : UpdateMarketingMemberCardOpenCardRightsRequest.Types.Guide
            {
            }
        }

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
        /// 获取或设置更新前用户积分（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("before_bonus_value")]
        [System.Text.Json.Serialization.JsonPropertyName("before_bonus_value")]
        public int? BonusValueBefore { get; set; }

        /// <summary>
        /// 获取或设置更新后用户积分（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bonus_value")]
        [System.Text.Json.Serialization.JsonPropertyName("bonus_value")]
        public int? BonusValue { get; set; }

        /// <summary>
        /// 获取或设置本次积分变动值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("add_bonus_value")]
        [System.Text.Json.Serialization.JsonPropertyName("add_bonus_value")]
        public int? BonusDiff { get; set; }

        /// <summary>
        /// 获取或设置商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否发送积分变更通知。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_inform_bonus")]
        [System.Text.Json.Serialization.JsonPropertyName("need_inform_bonus")]
        public bool? RequreInformBonus { get; set; }

        /// <summary>
        /// 获取或设置会员专享价文案。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("member_price_word")]
        [System.Text.Json.Serialization.JsonPropertyName("member_price_word")]
        public string? MemberPriceWords { get; set; }

        /// <summary>
        /// 获取或设置发票跳转文案。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fapiao_jump_word")]
        [System.Text.Json.Serialization.JsonPropertyName("fapiao_jump_word")]
        public string? InvoiceJumpWords { get; set; }

        /// <summary>
        /// 获取或设置客服信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide")]
        [System.Text.Json.Serialization.JsonPropertyName("guide")]
        public Types.Guide? Guide { get; set; }
    }
}
