namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /marketing/membercard-open/cards/{card_id}/rights 接口的请求。</para>
    /// </summary>
    public class UpdateMarketingMemberCardOpenCardRightsRequest : WechatTenpayRequest
    {
        public static class Types 
        {
            public class Bonus
            {
                
                /// <summary>
                /// 获取或设置会员初始积分值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("init_bonus")]
                [System.Text.Json.Serialization.JsonPropertyName("init_bonus")]
                public int InitialBonusValue { get; set; } 

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
                public bool? RequireShowCoupon { get; set; }

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

                /// <summary>
                /// 获取或设置会员专享价标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("member_price_title")]
                [System.Text.Json.Serialization.JsonPropertyName("member_price_title")]
                public string? MemberPriceTitle { get; set; } 

                /// <summary>
                /// 获取或设置会员优惠栏目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("favor_module_title")]
                [System.Text.Json.Serialization.JsonPropertyName("favor_module_title")]
                public string? FavorModuleTitle { get; set; } 
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
                public string? StaffName { get; set; }

                /// <summary>
                /// 获取或设置联系人头像媒体文件地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_image_url")]
                [System.Text.Json.Serialization.JsonPropertyName("head_image_url")]
                public string? HeadImageMediaUrl { get; set; }

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
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CardId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否展示会员积分。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("show_bonus")]
        [System.Text.Json.Serialization.JsonPropertyName("show_bonus")]
        public bool? RequireShowBonus { get; set; }

        /// <summary>
        /// 获取或设置积分信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bonus")]
        [System.Text.Json.Serialization.JsonPropertyName("bonus")]
        public Types.Bonus? Bonus { get; set; }

        /// <summary>
        /// 获取或设置是否展示会员优惠。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("show_favor")]
        [System.Text.Json.Serialization.JsonPropertyName("show_favor")]
        public bool? RequireShowFavor { get; set; }

        /// <summary>
        /// 获取或设置优惠信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("favor")]
        [System.Text.Json.Serialization.JsonPropertyName("favor")]
        public Types.Favor? Favor { get; set; }

        /// <summary>
        /// 获取或设置是否展示发票。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("show_fapiao")]
        [System.Text.Json.Serialization.JsonPropertyName("show_fapiao")]
        public bool? RequireShowInvoice { get; set; }

        /// <summary>
        /// 获取或设置会员发票信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fapiao")]
        [System.Text.Json.Serialization.JsonPropertyName("fapiao")]
        public Types.Invoice? Invoice { get; set; }

        /// <summary>
        /// 获取或设置是否展示客服。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("show_guide")]
        [System.Text.Json.Serialization.JsonPropertyName("show_guide")]
        public bool? RequireShowGuide { get; set; }

        /// <summary>
        /// 获取或设置客服信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide")]
        [System.Text.Json.Serialization.JsonPropertyName("guide")]
        public Types.Guide? Guide { get; set; }
    }
}
