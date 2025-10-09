using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /brand/partner/card-member/cards/{card_id} 接口的响应。</para>
    /// </summary>
    public class GetBrandPartnerCardMemberCardByCardIdResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class ValidDateInfo : QueryBrandPartnerCardMemberCardsResponse.Types.Card.Types.ValidDateInfo
            {
            }

            public class JumpInfo : QueryBrandPartnerCardMemberCardsResponse.Types.Card.Types.JumpInfo
            {
            }

            public class PurchaseJumpInfo : QueryBrandPartnerCardMemberCardsResponse.Types.Card.Types.PurchaseJumpInfo
            {
            }

            public class UserInfo : QueryBrandPartnerCardMemberCardsResponse.Types.Card.Types.UserInfo
            {
            }
        }

        /// <summary>
        /// 获取或设置商家请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置会员卡模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = default!;

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string BrandId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商家 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置会员卡类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_type")]
        [System.Text.Json.Serialization.JsonPropertyName("card_type")]
        public string CardType { get; set; } = default!;

        /// <summary>
        /// 获取或设置会员卡名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_title")]
        [System.Text.Json.Serialization.JsonPropertyName("card_title")]
        public string CardTitle { get; set; } = default!;

        /// <summary>
        /// 获取或设置会员卡背景颜色。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_color")]
        [System.Text.Json.Serialization.JsonPropertyName("card_color")]
        public string CardColor { get; set; } = default!;

        /// <summary>
        /// 获取或设置会员卡图片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_picture_url")]
        [System.Text.Json.Serialization.JsonPropertyName("card_picture_url")]
        public string CardPictureUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置会员卡 Code 分配类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("code_mode")]
        public string CodeMode { get; set; } = default!;

        /// <summary>
        /// 获取或设置会员码展示类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_type")]
        [System.Text.Json.Serialization.JsonPropertyName("code_type")]
        public string CodeType { get; set; } = default!;

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
        public string Benefits { get; set; } = default!;

        /// <summary>
        /// 获取或设置回调地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string NotifyUrl { get; set; } = default!;

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

        /// <summary>
        /// 获取或设置会员卡状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// 获取或设置创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }

        /// <summary>
        /// 获取或设置更新时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("modify_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("modify_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset ModifyTime { get; set; }
    }
}
