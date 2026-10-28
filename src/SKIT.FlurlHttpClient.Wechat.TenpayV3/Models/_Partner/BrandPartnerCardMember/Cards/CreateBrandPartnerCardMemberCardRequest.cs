namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /brand/partner/card-member/cards 接口的请求。</para>
    /// </summary>
    public class CreateBrandPartnerCardMemberCardRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class ValidDateInfo
            {
                /// <summary>
                /// 获取或设置有效期类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string? Type { get; set; }

                /// <summary>
                /// 获取或设置有效期开始时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("available_begin_time")]
                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("available_begin_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset? AvailableBeginTime { get; set; }

                /// <summary>
                /// 获取或设置有效期结束时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("available_end_time")]
                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("available_end_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset? AvailableEndTime { get; set; }

                /// <summary>
                /// 获取或设置领取后 N 天内有效。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("available_day_after_receive")]
                [System.Text.Json.Serialization.JsonPropertyName("available_day_after_receive")]
                public int? AvailableDaysAfterReceive { get; set; }
            }

            public class JumpInfo
            {
                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("jump_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("jump_appid")]
                public string? JumpAppId { get; set; }

                /// <summary>
                /// 获取或设置小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("jump_path")]
                [System.Text.Json.Serialization.JsonPropertyName("jump_path")]
                public string? JumpPagePath { get; set; }
            }

            public class PurchaseJumpInfo : JumpInfo
            {
                /// <summary>
                /// 获取或设置付费会员价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price")]
                [System.Text.Json.Serialization.JsonPropertyName("price")]
                public int? Price { get; set; }
            }

            public class UserInfo
            {
                public static class Types
                {
                    public class CustomField
                    {
                        /// <summary>
                        /// 获取或设置字段类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string? Type { get; set; }

                        /// <summary>
                        /// 获取或设置字段名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string? Name { get; set; }

                        /// <summary>
                        /// 获取或设置字段值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("values")]
                        [System.Text.Json.Serialization.JsonPropertyName("values")]
                        public List<string>? Values { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置通用开卡信息字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("common_field_list")]
                [System.Text.Json.Serialization.JsonPropertyName("common_field_list")]
                public List<string>? CommonFieldList { get; set; }

                /// <summary>
                /// 获取或设置自定义开卡信息字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_field_list")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_field_list")]
                public List<Types.CustomField>? CustomFieldList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商家请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string? OutRequestNumber { get; set; }

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string? BrandId { get; set; }

        /// <summary>
        /// 获取或设置商家 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

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
        /// 获取或设置会员卡 Code 分配类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("code_mode")]
        public string? CodeMode { get; set; }

        /// <summary>
        /// 获取或设置会员码展示类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_type")]
        [System.Text.Json.Serialization.JsonPropertyName("code_type")]
        public string? CodeType { get; set; }

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
        public string? Benefits { get; set; }

        /// <summary>
        /// 获取或设置回调地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

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
        /// 获取或设置是否支持用户主动入会。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("support_user_active_join")]
        [System.Text.Json.Serialization.JsonPropertyName("support_user_active_join")]
        public bool? IsSupportUserActiveJoin { get; set; }

        /// <summary>
        /// 获取或设置是否为付费会员。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("purchase_membership")]
        [System.Text.Json.Serialization.JsonPropertyName("purchase_membership")]
        public bool? IsPurchaseMembership { get; set; }
    }
}
