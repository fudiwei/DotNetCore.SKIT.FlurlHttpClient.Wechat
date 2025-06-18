using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/membercard-open/cards 接口的响应。</para>
    /// </summary>
    public class QueryMarketingMemberCardOpenCardsResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Card
            {
                public static class Types
                {
                    public class Brand : GetMarketingMemberCardOpenCardByCardIdResponse.Types.Brand
                    {
                    }

                    public class Date : GetMarketingMemberCardOpenCardByCardIdResponse.Types.Date
                    {
                    }

                    public class Balance : GetMarketingMemberCardOpenCardByCardIdResponse.Types.Balance
                    {
                    }

                    public class UserForm : GetMarketingMemberCardOpenCardByCardIdResponse.Types.UserForm
                    {
                    }

                    public class AdditionalStatement : GetMarketingMemberCardOpenCardByCardIdResponse.Types.AdditionalStatement
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
                public string? InitialLevel { get; set; }

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
                /// 获取或设置是否启用动态码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("need_dynamic_code")]
                [System.Text.Json.Serialization.JsonPropertyName("need_dynamic_code")]
                public bool? RequireDynamicCode { get; set; }

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
                [Newtonsoft.Json.JsonProperty("update_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset UpdateTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会员卡列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Card[] CardList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否启用动态码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_dynamic_code")]
        [System.Text.Json.Serialization.JsonPropertyName("need_dynamic_code")]
        public bool? RequireDynamicCode { get; set; }

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置会员卡总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
