namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/membercard/activate 接口的请求。</para>
    /// </summary>
    public class CardMemberCardActivateRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string? CardId { get; set; }

        /// <summary>
        /// 获取或设置卡券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string CardCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会员卡编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("membership_number")]
        [System.Text.Json.Serialization.JsonPropertyName("membership_number")]
        public string MembershipNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会员卡背景图 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("background_pic_url")]
        [System.Text.Json.Serialization.JsonPropertyName("background_pic_url")]
        public string? BackgroundPictureUrl { get; set; }

        /// <summary>
        /// 获取或设置激活后有效起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activate_begin_time")]
        [System.Text.Json.Serialization.JsonPropertyName("activate_begin_time")]
        public long? ActivateBeginTimestamp { get; set; }

        /// <summary>
        /// 获取或设置激活后有效截止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activate_end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("activate_end_time")]
        public long? ActivateEndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置初始积分。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("init_bonus")]
        [System.Text.Json.Serialization.JsonPropertyName("init_bonus")]
        public int? InitialBounus { get; set; }

        /// <summary>
        /// 获取或设置初始积分说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("init_bonus_record")]
        [System.Text.Json.Serialization.JsonPropertyName("init_bonus_record")]
        public string? InitialBounusRecord { get; set; }

        /// <summary>
        /// 获取或设置初始余额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("init_balance")]
        [System.Text.Json.Serialization.JsonPropertyName("init_balance")]
        public int? InitialBalance { get; set; }

        /// <summary>
        /// 获取或设置创建时字段 `CustomField1` 定义类型的初始值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("init_custom_field_value1")]
        [System.Text.Json.Serialization.JsonPropertyName("init_custom_field_value1")]
        public string? InitialCustomFieldValue1 { get; set; }

        /// <summary>
        /// 获取或设置创建时字段 `CustomField2` 定义类型的初始值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("init_custom_field_value2")]
        [System.Text.Json.Serialization.JsonPropertyName("init_custom_field_value2")]
        public string? InitialCustomFieldValue2 { get; set; }

        /// <summary>
        /// 获取或设置创建时字段 `CustomField3` 定义类型的初始值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("init_custom_field_value3")]
        [System.Text.Json.Serialization.JsonPropertyName("init_custom_field_value3")]
        public string? InitialCustomFieldValue3 { get; set; }
    }
}
