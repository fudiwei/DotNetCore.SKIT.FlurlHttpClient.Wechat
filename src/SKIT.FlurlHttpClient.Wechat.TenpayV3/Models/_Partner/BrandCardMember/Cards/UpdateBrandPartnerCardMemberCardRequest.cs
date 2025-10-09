namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /brand/partner/card-member/cards/{card_id} 接口的请求。</para>
    /// </summary>
    public class UpdateBrandPartnerCardMemberCardRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class ValidDateInfo : CreateBrandPartnerCardMemberCardRequest.Types.ValidDateInfo
            {
            }

            public class JumpInfo : CreateBrandPartnerCardMemberCardRequest.Types.JumpInfo
            {
            }

            public class PurchaseJumpInfo : CreateBrandPartnerCardMemberCardRequest.Types.PurchaseJumpInfo
            {
            }

            public class UserInfo : CreateBrandPartnerCardMemberCardRequest.Types.UserInfo
            {
            }
        }

        /// <summary>
        /// 获取或设置会员卡模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CardId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string BrandId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会员卡类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_type")]
        [System.Text.Json.Serialization.JsonPropertyName("card_type")]
        public string? CardType { get; set; }

        /// <summary>
        /// 获取或设置会员卡名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_title")]
        [System.Text.Json.Serialization.JsonPropertyName("card_title")]
        public string? CardTitle { get; set; }

        /// <summary>
        /// 获取或设置会员卡背景颜色。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_color")]
        [System.Text.Json.Serialization.JsonPropertyName("card_color")]
        public string? CardColor { get; set; }

        /// <summary>
        /// 获取或设置会员卡图片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_picture_url")]
        [System.Text.Json.Serialization.JsonPropertyName("card_picture_url")]
        public string? CardPictureUrl { get; set; }

        /// <summary>
        /// 获取或设置会员码跳转信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_jump_information")]
        [System.Text.Json.Serialization.JsonPropertyName("code_jump_information")]
        public Types.JumpInfo? CodeJumpInfo { get; set; }

        /// <summary>
        /// 获取或设置会员中心跳转信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("member_information")]
        [System.Text.Json.Serialization.JsonPropertyName("member_information")]
        public Types.JumpInfo? MemberJumpInfo { get; set; }

        /// <summary>
        /// 获取或设置积分跳转信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("points_information")]
        [System.Text.Json.Serialization.JsonPropertyName("points_information")]
        public Types.JumpInfo? PointsJumpInfo { get; set; }

        /// <summary>
        /// 获取或设置储值跳转信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance_information")]
        [System.Text.Json.Serialization.JsonPropertyName("balance_information")]
        public Types.JumpInfo? BalanceJumpInfo { get; set; }

        /// <summary>
        /// 获取或设置付费会员跳转信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("purchase_information")]
        [System.Text.Json.Serialization.JsonPropertyName("purchase_information")]
        public Types.PurchaseJumpInfo? PurchaseJumpInfo { get; set; }

        /// <summary>
        /// 获取或设置会员权益。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("benefits")]
        [System.Text.Json.Serialization.JsonPropertyName("benefits")]
        public string Benefits { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置回调地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string NotifyUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否置顶。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_pinned")]
        [System.Text.Json.Serialization.JsonPropertyName("need_pinned")]
        public bool? IsPinned { get; set; }

        /// <summary>
        /// 获取或设置是否展示会员等级。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_display_level")]
        [System.Text.Json.Serialization.JsonPropertyName("need_display_level")]
        public bool? IsDisplayLevel { get; set; }

        /// <summary>
        /// 获取或设置会员初始等级。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("init_level")]
        [System.Text.Json.Serialization.JsonPropertyName("init_level")]
        public string? InitialLevel { get; set; }

        /// <summary>
        /// 获取或设置服务电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("service_phone")]
        public string? ServicePhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置商家法务协议。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("legal_agreement")]
        [System.Text.Json.Serialization.JsonPropertyName("legal_agreement")]
        public string? LegalAgreement { get; set; }

        /// <summary>
        /// 获取或设置会员卡有效期信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("valid_date_information")]
        [System.Text.Json.Serialization.JsonPropertyName("valid_date_information")]
        public Types.ValidDateInfo? ValidDateInfo { get; set; }

        /// <summary>
        /// 获取或设置用户开卡信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_information")]
        [System.Text.Json.Serialization.JsonPropertyName("user_information")]
        public Types.UserInfo? UserInfo { get; set; }
    }
}
