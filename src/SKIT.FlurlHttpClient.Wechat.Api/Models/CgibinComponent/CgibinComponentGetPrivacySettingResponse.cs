namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/getprivacysetting 接口的响应。</para>
    /// </summary>
    public class CgibinComponentGetPrivacySettingResponse : WechatApiResponse
    {
        public static class Types
        {
            public class OwnerSetting : CgibinComponentGetPrivacySettingRequest.Types.OwnerSetting
            {
            }

            public class PrivacySetting : CgibinComponentGetPrivacySettingRequest.Types.PrivacySetting
            {
                /// <summary>
                /// 获取或设置用户信息类型的中文名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("privacy_label")]
                [System.Text.Json.Serialization.JsonPropertyName("privacy_label")]
                public string PrivacyLabel { get; set; } = default!;
            }

            public class PrivacyDescriptionList
            {
                /// <summary>
                /// 获取或设置用户信息类型对应的中英文描述列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("privacy_desc_list")]
                [System.Text.Json.Serialization.JsonPropertyName("privacy_desc_list")]
                public PrivacyDescriptionItem[] Items { get; set; } = default!;
            }

            public class PrivacyDescriptionItem
            {
                /// <summary>
                /// 获取或设置用户信息类型的英文名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("privacy_key")]
                [System.Text.Json.Serialization.JsonPropertyName("privacy_key")]
                public string PrivacyKey { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户信息类型的中文描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("privacy_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("privacy_desc")]
                public string PrivacyDescription { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置代码是否存在。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_exist")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("code_exist")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool IsCodeExisted { get; set; }

        /// <summary>
        /// 获取或设置收集方信息配置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("owner_setting")]
        [System.Text.Json.Serialization.JsonPropertyName("owner_setting")]
        public Types.OwnerSetting? OwnerSetting { get; set; }

        /// <summary>
        /// 获取或设置要收集的用户信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("privacy_list")]
        [System.Text.Json.Serialization.JsonPropertyName("privacy_list")]
        public string[]? PrivacyKeyList { get; set; }

        /// <summary>
        /// 获取或设置要收集的用户信息配置列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("setting_list")]
        [System.Text.Json.Serialization.JsonPropertyName("setting_list")]
        public Types.PrivacySetting[]? PrivacySettingList { get; set; }

        /// <summary>
        /// 获取或设置用户信息类型对应的中英文描述信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("privacy_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("privacy_desc")]
        public Types.PrivacyDescriptionList? PrivacyDescriptionList { get; set; }

        /// <summary>
        /// 获取或设置更新时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time")]
        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
        public long? UpdateTimestamp { get; set; }
    }
}
