using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/membercard-open/cards 接口的请求。</para>
    /// </summary>
    public class CreateMarketingMemberCardOpenCardRequest : WechatTenpayRequest
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
                public string BrandId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置展示名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("display_name")]
                [System.Text.Json.Serialization.JsonPropertyName("display_name")]
                public string DisplayName { get; set; } = string.Empty;
            }

            public class Date
            {
                /// <summary>
                /// 获取或设置有效期类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = string.Empty;

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
                        public string Type { get; set; } = string.Empty;
                        
                        /// <summary>
                        /// 获取或设置字段名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;
                        
                        /// <summary>
                        /// 获取或设置字段值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("values")]
                        [System.Text.Json.Serialization.JsonPropertyName("values")]
                        public IList<string>? Values { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置平台提供的通用开卡信息字段名称列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("common_field_list")]
                [System.Text.Json.Serialization.JsonPropertyName("common_field_list")]
                public IList<string>? CommonFieldNameList { get; set; }

                /// <summary>
                /// 获取或设置商户自定义的开卡信息字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_field_list")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_field_list")]
                public IList<Types.CustomField>? CustomFieldList { get; set; }
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
        }

        /// <summary>
        /// 获取或设置公众号 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会员卡 Logo 媒体文件地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logo_url")]
        [System.Text.Json.Serialization.JsonPropertyName("logo_url")]
        public string LogoMediaUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置品牌信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand")]
        [System.Text.Json.Serialization.JsonPropertyName("brand")]
        public Types.Brand Brand { get; set; } = new Types.Brand();

        /// <summary>
        /// 获取或设置卡名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置背景图片媒体文件地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("background_picture_url")]
        [System.Text.Json.Serialization.JsonPropertyName("background_picture_url")]
        public string BackgroundPictureMediaUrl { get; set; } = string.Empty;

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
        public string CodeType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会员卡总库存。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_quantity")]
        [System.Text.Json.Serialization.JsonPropertyName("total_quantity")]
        public int? TotalQuantity { get; set; }

        /// <summary>
        /// 获取或设置有效期。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_information")]
        [System.Text.Json.Serialization.JsonPropertyName("date_information")]
        public Types.Date Date { get; set; } = new Types.Date();

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
        public string? InitialLevel { get; set; }

        /// <summary>
        /// 获取或设置商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;

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
        /// 获取或设置是否启用动态码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_dynamic_code")]
        [System.Text.Json.Serialization.JsonPropertyName("need_dynamic_code")]
        public bool? RequireDynamicCode { get; set; }
    }
}
