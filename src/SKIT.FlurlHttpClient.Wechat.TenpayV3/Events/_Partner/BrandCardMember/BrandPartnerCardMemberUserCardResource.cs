using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 BRAND_MEMBER_CARD_SP.USER_CARD.CREATE （仅限服务商）通知的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015283692 ]]>
    /// </para>
    /// </summary>
    public class BrandPartnerCardMemberUserCardResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        public static class Types
        {
            public class ValidDateInfo : Models.QueryBrandPartnerCardMemberUserCardsResponse.Types.UserCard.Types.ValidDateInfo
            {
            }

            public class UserInfo
            {
                public static class Types
                {
                    public class CommonField
                    {
                        /// <summary>
                        /// 获取或设置字段名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置字段值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public string? Value { get; set; }
                    }

                    public class CustomField
                    {
                        /// <summary>
                        /// 获取或设置字段名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置字段值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_chosen_values")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_chosen_values")]
                        public string[]? Values { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置通用开卡信息字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("common_field_list")]
                [System.Text.Json.Serialization.JsonPropertyName("common_field_list")]
                public Types.CommonField[]? CommonFieldList { get; set; }

                /// <summary>
                /// 获取或设置自定义开卡信息字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_field_list")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_field_list")]
                public Types.CustomField[]? CustomFieldList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会员卡 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_card_code")]
        [System.Text.Json.Serialization.JsonPropertyName("user_card_code")]
        public string UserCardCode { get; set; } = default!;

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
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置会员卡类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_type")]
        [System.Text.Json.Serialization.JsonPropertyName("card_type")]
        public string CardType { get; set; } = default!;

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
        /// 获取或设置用户的手机号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_number")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        public string? MobileNumber { get; set; }

        /// <summary>
        /// 获取或设置会员等级。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("level")]
        [System.Text.Json.Serialization.JsonPropertyName("level")]
        public string? Level { get; set; }

        /// <summary>
        /// 获取或设置会员卡有效期信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("valid_date_information")]
        [System.Text.Json.Serialization.JsonPropertyName("valid_date_information")]
        public Types.ValidDateInfo? ValidDateInfo { get; set; }

        /// <summary>
        /// 获取或设置领取时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pickup_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("pickup_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset PickupTime { get; set; }

        /// <summary>
        /// 获取或设置用户开卡信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_information")]
        [System.Text.Json.Serialization.JsonPropertyName("user_information")]
        public Types.UserInfo? UserInfo { get; set; }

        /// <summary>
        /// 获取或设置附加数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置会员卡状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_card_state")]
        [System.Text.Json.Serialization.JsonPropertyName("user_card_state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// 获取或设置作废原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_reason")]
        public string? InvalidReason { get; set; }

        /// <summary>
        /// 获取或设置作废时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? InvalidTime { get; set; }

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
