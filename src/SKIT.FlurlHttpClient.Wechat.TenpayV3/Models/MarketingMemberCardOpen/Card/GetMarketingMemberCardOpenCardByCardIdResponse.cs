using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/membercard-open/cards/{card_id} 接口的响应。</para>
    /// </summary>
    public class GetMarketingMemberCardOpenCardByCardIdResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Brand
            {
                /// <summary>
                /// 获取或设置品牌 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_id")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
                public string BrandId { get; set; } = default!;

                /// <summary>
                /// 获取或设置展示名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("display_name")]
                [System.Text.Json.Serialization.JsonPropertyName("display_name")]
                public string DisplayName { get; set; } = default!;
            }

            public class Date
            {
                /// <summary>
                /// 获取或设置有效期类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置有效期开始时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("available_begin_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("available_begin_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                public DateTimeOffset? AvailableBeginTime { get; set; }

                /// <summary>
                /// 获取或设置有效期结束时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("available_end_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("available_end_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                public DateTimeOffset? AvailableEndTime { get; set; }

                /// <summary>
                /// 获取或设置领取后 N 天内有效。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("available_day_after_receive")]
                [System.Text.Json.Serialization.JsonPropertyName("available_day_after_receive")]
                public int? AvailableDaysAfterReceive { get; set; }

                /// <summary>
                /// 获取或设置领取后 N 天后生效。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wait_days_after_receive")]
                [System.Text.Json.Serialization.JsonPropertyName("wait_days_after_receive")]
                public int? WaitDaysAfterReceive { get; set; }
            }

            public class Balance
            {
                /// <summary>
                /// 获取或设置是否支持储值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("need_balance")]
                [System.Text.Json.Serialization.JsonPropertyName("need_balance")]
                public bool? RequireBalance { get; set; }

                /// <summary>
                /// 获取或设置储值小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("balance_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("balance_appid")]
                public string? MiniProgramAppId { get; set; }

                /// <summary>
                /// 获取或设置储值小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("balance_path")]
                [System.Text.Json.Serialization.JsonPropertyName("balance_path")]
                public string? MiniProgramPath { get; set; }

                /// <summary>
                /// 获取或设置储值 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("balance_url")]
                [System.Text.Json.Serialization.JsonPropertyName("balance_url")]
                public string? Url { get; set; }
            }

            public class UserForm
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
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置字段名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置字段值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("values")]
                        [System.Text.Json.Serialization.JsonPropertyName("values")]
                        public string[]? Values { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置是否允许修改。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("can_modify_after_activate")]
                [System.Text.Json.Serialization.JsonPropertyName("can_modify_after_activate")]
                public bool? CanModifyAfterActivate { get; set; }

                /// <summary>
                /// 获取或设置平台提供的通用开卡信息字段名称列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("common_field_list")]
                [System.Text.Json.Serialization.JsonPropertyName("common_field_list")]
                public string[]? CommonFieldNameList { get; set; }

                /// <summary>
                /// 获取或设置商户自定义的开卡信息字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_field_list")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_field_list")]
                public Types.CustomField[]? CustomFieldList { get; set; }
            }

            public class AdditionalStatement
            {
                /// <summary>
                /// 获取或设置标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string? MiniProgramAppId { get; set; }

                /// <summary>
                /// 获取或设置小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string? MiniProgramPath { get; set; }

                /// <summary>
                /// 获取或设置 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string? Url { get; set; }
            }

            public class Bonus
            {
                /// <summary>
                /// 获取或设置会员初始积分值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("init_bonus")]
                [System.Text.Json.Serialization.JsonPropertyName("init_bonus")]
                public int InitializedValue { get; set; } 

                /// <summary>
                /// 获取或设置积分值文案。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bonus_value_word")]
                [System.Text.Json.Serialization.JsonPropertyName("bonus_value_word")]
                public string? ValueWords { get; set; } 

                /// <summary>
                /// 获取或设置积分价值项标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bonus_cost_title")]
                [System.Text.Json.Serialization.JsonPropertyName("bonus_cost_title")]
                public string? CostTitle { get; set; } 

                /// <summary>
                /// 获取或设置积分价值项文案。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bonus_cost_word")]
                [System.Text.Json.Serialization.JsonPropertyName("bonus_cost_word")]
                public string? CostWords { get; set; } 

                /// <summary>
                /// 获取或设置跳转文案。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bonus_jump_word")]
                [System.Text.Json.Serialization.JsonPropertyName("bonus_jump_word")]
                public string? JumpWords { get; set; } 

                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bonus_jump_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("bonus_jump_appid")]
                public string? MiniProgramAppId { get; set; } 

                /// <summary>
                /// 获取或设置小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bonus_jump_path")]
                [System.Text.Json.Serialization.JsonPropertyName("bonus_jump_path")]
                public string? MiniProgramPath { get; set; } 

                /// <summary>
                /// 获取或设置自助小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bonus_support_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("bonus_support_appid")]
                public string? SupportMiniProgramAppId { get; set; } 

                /// <summary>
                /// 获取或设置自助小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bonus_support_path")]
                [System.Text.Json.Serialization.JsonPropertyName("bonus_support_path")]
                public string? SupportMiniProgramPath { get; set; } 
            }

            public class Favor
            {
                /// <summary>
                /// 获取或设置是否展示优惠券。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("show_coupon")]
                [System.Text.Json.Serialization.JsonPropertyName("show_coupon")]
                public bool RequireShowCoupon { get; set; }

                /// <summary>
                /// 获取或设置会员专享价文案。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("member_price_word")]
                [System.Text.Json.Serialization.JsonPropertyName("member_price_word")]
                public string? MemberPriceWords { get; set; }

                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("member_price_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("member_price_appid")]
                public string? MiniProgramAppId { get; set; } 

                /// <summary>
                /// 获取或设置小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("member_price_path")]
                [System.Text.Json.Serialization.JsonPropertyName("member_price_path")]
                public string? MiniProgramPath { get; set; } 
            }

            public class ServiceModule
            {
                public static class Types
                {
                    public class MiniProgram
                    {
                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string AppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("path")]
                        [System.Text.Json.Serialization.JsonPropertyName("path")]
                        public string Path { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置会员服务项 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_module_id")]
                [System.Text.Json.Serialization.JsonPropertyName("service_module_id")]
                public string ServiceModuleId { get; set; } = default!;

                /// <summary>
                /// 获取或设置跳转小程序信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("jump_miniprogram")]
                [System.Text.Json.Serialization.JsonPropertyName("jump_miniprogram")]
                public Types.MiniProgram? MiniProgram { get; set; }
            }

            public class Invoice
            {
                /// <summary>
                /// 获取或设置跳转文案。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fapiao_jump_word")]
                [System.Text.Json.Serialization.JsonPropertyName("fapiao_jump_word")]
                public string? JumpWords { get; set; } 

                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fapiao_jump_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("fapiao_jump_appid")]
                public string? MiniProgramAppId { get; set; } 

                /// <summary>
                /// 获取或设置小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fapiao_jump_path")]
                [System.Text.Json.Serialization.JsonPropertyName("fapiao_jump_path")]
                public string? MiniProgramPath { get; set; } 
            }

            public class Guide
            {
                /// <summary>
                /// 获取或设置联系人名字。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("staff_name")]
                [System.Text.Json.Serialization.JsonPropertyName("staff_name")]
                public string StaffName { get; set; } = default!;

                /// <summary>
                /// 获取或设置联系人头像媒体文件地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_image_url")]
                [System.Text.Json.Serialization.JsonPropertyName("head_image_url")]
                public string HeadImageMediaUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置联系方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_information_name")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_information_name")]
                public string? ContactInformationName { get; set; }

                /// <summary>
                /// 获取或设置联系信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_information_value")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_information_value")]
                public string? ContactInformationValue { get; set; }

                /// <summary>
                /// 获取或设置联系电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone_number")]
                [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
                public string? PhoneNumber { get; set; } 
            }
        }

        /// <summary>
        /// 获取或设置会员卡 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = default!;

        /// <summary>
        /// 获取或设置会员卡状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置公众号 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置会员卡 Logo 媒体文件地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logo_url")]
        [System.Text.Json.Serialization.JsonPropertyName("logo_url")]
        public string LogoMediaUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置品牌信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand")]
        [System.Text.Json.Serialization.JsonPropertyName("brand")]
        public Types.Brand Brand { get; set; } = default!;

        /// <summary>
        /// 获取或设置卡名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 获取或设置背景图片媒体文件地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("background_picture_url")]
        [System.Text.Json.Serialization.JsonPropertyName("background_picture_url")]
        public string BackgroundPictureMediaUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置使用须知。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置客服电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("service_phone")]
        public string? ServicePhone { get; set; }

        /// <summary>
        /// 获取或设置会员码型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_type")]
        [System.Text.Json.Serialization.JsonPropertyName("code_type")]
        public string CodeType { get; set; } = default!;

        /// <summary>
        /// 获取或设置会员卡总库存。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_quantity")]
        [System.Text.Json.Serialization.JsonPropertyName("total_quantity")]
        public int TotalQuantity { get; set; }

        /// <summary>
        /// 获取或设置剩余库存。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remain_quantity")]
        [System.Text.Json.Serialization.JsonPropertyName("remain_quantity")]
        public int? RemainQuantity { get; set; }

        /// <summary>
        /// 获取或设置有效期。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_information")]
        [System.Text.Json.Serialization.JsonPropertyName("date_information")]
        public Types.Date Date { get; set; } = default!;

        /// <summary>
        /// 获取或设置会员卡 Code 分配类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("code_mode")]
        public string? CodeMode { get; set; }

        /// <summary>
        /// 获取或设置是否展示会员等级。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_display_level")]
        [System.Text.Json.Serialization.JsonPropertyName("need_display_level")]
        public bool? RequireDisplayLevel { get; set; }

        /// <summary>
        /// 获取或设置会员初始等级。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("init_level")]
        [System.Text.Json.Serialization.JsonPropertyName("init_level")]
        public string? InitializedLevel { get; set; }

        /// <summary>
        /// 获取或设置商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置储值信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance_information")]
        [System.Text.Json.Serialization.JsonPropertyName("balance_information")]
        public Types.Balance? Balance { get; set; }

        /// <summary>
        /// 获取或设置开卡信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_information_form")]
        [System.Text.Json.Serialization.JsonPropertyName("user_information_form")]
        public Types.UserForm? UserForm { get; set; }

        /// <summary>
        /// 获取或设置补充说明信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("additional_statement")]
        [System.Text.Json.Serialization.JsonPropertyName("additional_statement")]
        public Types.AdditionalStatement? AdditionalStatement { get; set; }

        /// <summary>
        /// 获取或设置会员积分信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bonus")]
        [System.Text.Json.Serialization.JsonPropertyName("bonus")]
        public Types.Bonus? Bonus { get; set; }

        /// <summary>
        /// 获取或设置会员优惠信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("favor")]
        [System.Text.Json.Serialization.JsonPropertyName("favor")]
        public Types.Favor? Favor { get; set; }

        /// <summary>
        /// 获取或设置会员服务项列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_modules")]
        [System.Text.Json.Serialization.JsonPropertyName("service_modules")]
        public Types.ServiceModule[]? ServiceModuleList { get; set; }

        /// <summary>
        /// 获取或设置会员发票信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fapiao")]
        [System.Text.Json.Serialization.JsonPropertyName("fapiao")]
        public Types.Invoice? Invoice { get; set; }

        /// <summary>
        /// 获取或设置客服信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide")]
        [System.Text.Json.Serialization.JsonPropertyName("guide")]
        public Types.Guide? Guide { get; set; }

        /// <summary>
        /// 获取或设置是否启用动态码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_dynamic_code")]
        [System.Text.Json.Serialization.JsonPropertyName("need_dynamic_code")]
        public bool? RequireDynamicCode { get; set; }

        /// <summary>
        /// 获取或设置创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }

        /// <summary>
        /// 获取或设置更新时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset UpdateTime { get; set; }
    }
}
