using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /marketing/membercard-open/cards/{card_id} 接口的请求。</para>
    /// </summary>
    public class UpdateMarketingMemberCardOpenCardRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Date : CreateMarketingMemberCardOpenCardRequest.Types.Date
            {
            }

            public class Balance : CreateMarketingMemberCardOpenCardRequest.Types.Balance
            {
            }

            public class UserForm
            {
                public static class Types
                {
                    public class CustomField : CreateMarketingMemberCardOpenCardRequest.Types.UserForm.Types.CustomField
                    {
                    }
                }

                /// <summary>
                /// 获取或设置是否允许修改。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("can_modify_after_activate")]
                [System.Text.Json.Serialization.JsonPropertyName("can_modify_after_activate")]
                public bool? CanModifyAfterActivate { get; set; }

                /// <summary>
                /// 获取或设置平台提供的通用开卡信息字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("common_field_list")]
                [System.Text.Json.Serialization.JsonPropertyName("common_field_list")]
                public IList<string>? CommonFieldList { get; set; }

                /// <summary>
                /// 获取或设置商户自定义的开卡信息字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_field_list")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_field_list")]
                public IList<Types.CustomField>? CustomFieldList { get; set; }
            }

            public class AdditionalStatement : CreateMarketingMemberCardOpenCardRequest.Types.AdditionalStatement
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
        /// 获取或设置公众号 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; } 

        /// <summary>
        /// 获取或设置会员卡 Logo 媒体文件地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logo_url")]
        [System.Text.Json.Serialization.JsonPropertyName("logo_url")]
        public string? LogoMediaUrl { get; set; }

        /// <summary>
        /// 获取或设置卡名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 获取或设置背景图片媒体文件地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("background_picture_url")]
        [System.Text.Json.Serialization.JsonPropertyName("background_picture_url")]
        public string? BackgroundPictureMediaUrl { get; set; }

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
        public Types.Date? Date { get; set; }

        /// <summary>
        /// 获取或设置会员卡 Code 分配类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("code_mode")]
        public int? CodeMode { get; set; }

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
