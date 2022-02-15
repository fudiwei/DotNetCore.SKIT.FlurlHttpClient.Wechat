using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/membercard/updateuser 接口的请求。</para>
    /// </summary>
    public class CardMemberCardUpdateUserRequest : WechatApiRequest, IMapResponse<CardMemberCardUpdateUserRequest, CardMemberCardUpdateUserResponse>
    {
        public static class Types
        {
            public class NotifyOption
            {
                /// <summary>
                /// 获取或设置积分变动时是否触发系统模板消息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_notify_bonus")]
                [System.Text.Json.Serialization.JsonPropertyName("is_notify_bonus")]
                public bool? IsNotifyBonus { get; set; }

                /// <summary>
                /// 获取或设置余额变动时是否触发系统模板消息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_notify_balance")]
                [System.Text.Json.Serialization.JsonPropertyName("is_notify_balance")]
                public bool? IsNotifyBalance { get; set; }

                /// <summary>
                /// 获取或设置字段 `CustomField1` 变动时是否触发系统模板消息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_notify_custom_field1")]
                [System.Text.Json.Serialization.JsonPropertyName("is_notify_custom_field1")]
                public bool? IsNotifyCustomField1 { get; set; }

                /// <summary>
                /// 获取或设置字段 `CustomField2` 变动时是否触发系统模板消息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_notify_custom_field2")]
                [System.Text.Json.Serialization.JsonPropertyName("is_notify_custom_field2")]
                public bool? IsNotifyCustomField2 { get; set; }

                /// <summary>
                /// 获取或设置字段 `CustomField3` 变动时是否触发系统模板消息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_notify_custom_field3")]
                [System.Text.Json.Serialization.JsonPropertyName("is_notify_custom_field3")]
                public bool? IsNotifyCustomField3 { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置卡券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string CardCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会员卡背景图 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("background_pic_url")]
        [System.Text.Json.Serialization.JsonPropertyName("background_pic_url")]
        public string? BackgroundPictureUrl { get; set; }

        /// <summary>
        /// 获取或设置积分。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bonus")]
        [System.Text.Json.Serialization.JsonPropertyName("bonus")]
        public int? Bounus { get; set; }

        /// <summary>
        /// 获取或设置本次积分变动值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("add_bonus")]
        [System.Text.Json.Serialization.JsonPropertyName("add_bonus")]
        public int? ModifiedBounus { get; set; }

        /// <summary>
        /// 获取或设置本次积分变动说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record_bonus")]
        [System.Text.Json.Serialization.JsonPropertyName("record_bonus")]
        public string? ModifiedBounusRecord { get; set; }

        /// <summary>
        /// 获取或设置余额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance")]
        [System.Text.Json.Serialization.JsonPropertyName("balance")]
        public int? Balance { get; set; }

        /// <summary>
        /// 获取或设置本次余额变动值（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("add_balance")]
        [System.Text.Json.Serialization.JsonPropertyName("add_balance")]
        public int? ModifiedBalance { get; set; }

        /// <summary>
        /// 获取或设置本次余额变动说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record_balance")]
        [System.Text.Json.Serialization.JsonPropertyName("record_balance")]
        public string? ModifiedBalanceRecord { get; set; }

        /// <summary>
        /// 获取或设置创建时字段 `CustomField1` 定义类型的最新值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_field_value1")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_field_value1")]
        public string? CustomFieldValue1 { get; set; }

        /// <summary>
        /// 获取或设置创建时字段 `CustomField2` 定义类型的最新值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_field_value2")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_field_value2")]
        public string? CustomFieldValue2 { get; set; }

        /// <summary>
        /// 获取或设置创建时字段 `CustomField3` 定义类型的最新值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_field_value3")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_field_value3")]
        public string? CustomFieldValue3 { get; set; }

        /// <summary>
        /// 获取或设置消息控制信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_optional")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_optional")]
        public Types.NotifyOption? NotifyOption { get; set; }
    }
}
