namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/membercard-open/cards/{card_id}/codes/{code} 接口的响应。</para>
    /// </summary>
    public class GetMarketingMemberCardOpenCardCodeByCardIdAndCodeResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class UserInformation
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
                        public string Value { get; set; } = default!;
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
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public string? Value { get; set; }

                        /// <summary>
                        /// 获取或设置字段值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("value_list")]
                        public string[]? Values { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置平台提供的通用开卡信息字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("common_field_list")]
                [System.Text.Json.Serialization.JsonPropertyName("common_field_list")]
                public Types.CommonField[]? CommonFieldList { get; set; }

                /// <summary>
                /// 获取或设置商户自定义的开卡信息字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_field_list")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_field_list")]
                public Types.CustomField[]? CustomFieldList { get; set; }
            }

            public class ServiceModule
            {
                public static class Types
                {
                    public class StateSetting
                    {
                        public static class Types
                        {
                            public class ContentTemplate
                            {
                                public static class Types
                                {
                                    public class Field
                                    {
                                        /// <summary>
                                        /// 获取或设置内容字段 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("field_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("field_id")]
                                        public string FieldId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置内容字段值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("field_value")]
                                        [System.Text.Json.Serialization.JsonPropertyName("field_value")]
                                        public string FieldValue { get; set; } = default!;
                                    }

                                    public class ActionSetting
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
                                        /// 获取或设置操作名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("action_name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("action_name")]
                                        public string ActionName { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置跳转小程序信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("jump_miniprogram")]
                                        [System.Text.Json.Serialization.JsonPropertyName("jump_miniprogram")]
                                        public Types.MiniProgram MiniProgram { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置内容字段列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("field_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("field_list")]
                                public Types.Field[] FieldList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置操作设置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("action_setting")]
                                [System.Text.Json.Serialization.JsonPropertyName("action_setting")]
                                public Types.ActionSetting? ActionSetting { get; set; }
                            }

                            public class TemplateMessageSetting
                            {
                                public static class Types
                                {
                                    public class Field
                                    {
                                        /// <summary>
                                        /// 获取或设置消息字段 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("field_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("field_id")]
                                        public string FieldId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置消息字段值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("field_value")]
                                        [System.Text.Json.Serialization.JsonPropertyName("field_value")]
                                        public string FieldValue { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置模板消息 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("message_template_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("message_template_id")]
                                public string TemplateMessageId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置消息字段列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("field_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("field_list")]
                                public Types.Field[]? FieldList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置状态 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("state_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("state_id")]
                        public string StateId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置内容模板信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content_template_data")]
                        [System.Text.Json.Serialization.JsonPropertyName("content_template_data")]
                        public Types.ContentTemplate? ContentTemplate { get; set; }

                        /// <summary>
                        /// 获取或设置模板消息设置信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("message_template_setting")]
                        [System.Text.Json.Serialization.JsonPropertyName("message_template_setting")]
                        public Types.TemplateMessageSetting? TemplateMessageSetting { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置会员服务项 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_module_id")]
                [System.Text.Json.Serialization.JsonPropertyName("service_module_id")]
                public string ServiceModuleId { get; set; } = default!;

                /// <summary>
                /// 获取或设置服务状态设置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state_setting")]
                [System.Text.Json.Serialization.JsonPropertyName("state_setting")]
                public Types.StateSetting? StateSetting { get; set; }
            }

            public class Guide : GetMarketingMemberCardOpenCardByCardIdResponse.Types.Guide
            {
            }
        }

        /// <summary>
        /// 获取或设置会员卡 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置会员卡编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("membership_number")]
        [System.Text.Json.Serialization.JsonPropertyName("membership_number")]
        public string? MembershipNumber { get; set; }

        /// <summary>
        /// 获取或设置用户等级。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("level")]
        [System.Text.Json.Serialization.JsonPropertyName("level")]
        public string? Level { get; set; }

        /// <summary>
        /// 获取或设置用户昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nickname")]
        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
        public string? Nickname { get; set; }

        /// <summary>
        /// 获取或设置用户头像 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("head_image_url")]
        [System.Text.Json.Serialization.JsonPropertyName("head_image_url")]
        public string? HeadImageUrl { get; set; }

        /// <summary>
        /// 获取或设置背景图片媒体文件地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("background_picture_url")]
        [System.Text.Json.Serialization.JsonPropertyName("background_picture_url")]
        public string? BackgroundPictureMediaUrl { get; set; }

        /// <summary>
        /// 获取或设置会员卡状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_card_status")]
        [System.Text.Json.Serialization.JsonPropertyName("user_card_status")]
        public string? Status { get; set; }

        /// <summary>
        /// 获取或设置用户储值余额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance")]
        [System.Text.Json.Serialization.JsonPropertyName("balance")]
        public int? BalanceValue { get; set; }

        /// <summary>
        /// 获取或设置用户当前积分。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bonus_value")]
        [System.Text.Json.Serialization.JsonPropertyName("bonus_value")]
        public int? BonusValue { get; set; }

        /// <summary>
        /// 获取或设置用户开卡时填写的个人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_information")]
        [System.Text.Json.Serialization.JsonPropertyName("user_information")]
        public Types.UserInformation? UserInformation { get; set; }

        /// <summary>
        /// 获取或设置会员服务项列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_modules")]
        [System.Text.Json.Serialization.JsonPropertyName("service_modules")]
        public Types.ServiceModule[]? ServiceModuleList { get; set; }

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

        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200;
        }
    }
}
