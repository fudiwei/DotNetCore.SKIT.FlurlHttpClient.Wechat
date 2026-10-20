namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /brand/partner/card-member/user-points/exchange-coupon/confirm 接口的请求。</para>
    /// </summary>
    public class ConfirmBrandPartnerCardMemberUserPointExchangeCouponRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置积分兑券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record_id")]
        [System.Text.Json.Serialization.JsonPropertyName("record_id")]
        public string RecordId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置积分兑券模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exchange_coupon_template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("exchange_coupon_template_id")]
        public string ExchangeCouponTemplateId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会员卡 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_card_code")]
        [System.Text.Json.Serialization.JsonPropertyName("user_card_code")]
        public string UserCardCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会员卡模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string BrandId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置积分兑券状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_code")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_code")]
        public string? CouponCode { get; set; }

        /// <summary>
        /// 获取或设置失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
        public string? FailReason { get; set; }
    }
}
