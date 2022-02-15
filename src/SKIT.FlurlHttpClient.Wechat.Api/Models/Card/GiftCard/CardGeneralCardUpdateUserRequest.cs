using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/generalcard/updateuser 接口的请求。</para>
    /// </summary>
    public class CardGeneralCardUpdateUserRequest : WechatApiRequest, IMapResponse<CardGeneralCardUpdateUserRequest, CardGeneralCardUpdateUserResponse>
    {
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
        /// 获取或设置礼品卡背景图 URL。
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
        /// 获取或设置积分变动说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record_bonus")]
        [System.Text.Json.Serialization.JsonPropertyName("record_bonus")]
        public string? BounusRecord { get; set; }

        /// <summary>
        /// 获取或设置余额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance")]
        [System.Text.Json.Serialization.JsonPropertyName("balance")]
        public int? Balance { get; set; }

        /// <summary>
        /// 获取或设置余额变动说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record_balance")]
        [System.Text.Json.Serialization.JsonPropertyName("record_balance")]
        public string? BalanceRecord { get; set; }

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
        /// 获取或设置是否可转增。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("can_give_friend")]
        [System.Text.Json.Serialization.JsonPropertyName("can_give_friend")]
        public bool? CanTransfer { get; set; }
    }
}
