namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/getprivacysetting 接口的请求。</para>
    /// </summary>
    public class CgibinComponentGetPrivacySettingRequest : WechatApiRequest, IMapResponse<CgibinComponentGetPrivacySettingRequest, CgibinComponentGetPrivacySettingResponse>
    {
        public static class Types
        {
            public class OwnerSetting
            {
                /// <summary>
                /// 获取或设置信息收集方的邮箱地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_email")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_email")]
                public string? ContactEmail { get; set; }

                /// <summary>
                /// 获取或设置信息收集方的电话号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_phone")]
                public string? ContactPhoneNumber { get; set; }

                /// <summary>
                /// 获取或设置信息收集方的 QQ 号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_qq")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_qq")]
                public string? ContactQQ { get; set; }

                /// <summary>
                /// 获取或设置信息收集方的微信号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_weixin")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_weixin")]
                public string? ContactWexin { get; set; }

                /// <summary>
                /// 获取或设置用户隐私保护指引文件的 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ext_file_media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ext_file_media_id")]
                public string? ExtraFileMediaId { get; set; }

                /// <summary>
                /// 获取或设置通知方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("notice_method")]
                [System.Text.Json.Serialization.JsonPropertyName("notice_method")]
                public string? NoticeMethod { get; set; }

                /// <summary>
                /// 获取或设置存储期限时间字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_expire_timestamp")]
                [System.Text.Json.Serialization.JsonPropertyName("store_expire_timestamp")]
                public string? StoreExpireTimeString { get; set; }
            }

            public class PrivacySetting
            {
                /// <summary>
                /// 获取或设置隐私项目标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("privacy_key")]
                [System.Text.Json.Serialization.JsonPropertyName("privacy_key")]
                public string PrivacyKey { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置收集该信息的用途。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("privacy_text")]
                [System.Text.Json.Serialization.JsonPropertyName("privacy_text")]
                public string PrivacyText { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置用户隐私保护指引的版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("privacy_ver")]
        [System.Text.Json.Serialization.JsonPropertyName("privacy_ver")]
        public int? PrivacyVersion { get; set; }
    }
}
