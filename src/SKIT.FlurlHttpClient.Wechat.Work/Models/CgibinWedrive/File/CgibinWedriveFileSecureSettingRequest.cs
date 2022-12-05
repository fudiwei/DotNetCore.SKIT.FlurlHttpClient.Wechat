namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_secure_setting 接口的请求。</para>
    /// </summary>
    public class CgibinWedriveFileSecureSettingRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Watermark
            {
                /// <summary>
                /// 获取或设置水印文字。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public string? Text { get; set; }

                /// <summary>
                /// 获取或设置水印类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("margin_type")]
                [System.Text.Json.Serialization.JsonPropertyName("margin_type")]
                public int? MarginType { get; set; }

                /// <summary>
                /// 获取或设置是否开启水印文本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("show_text")]
                [System.Text.Json.Serialization.JsonPropertyName("show_text")]
                public bool? EnableShowText { get; set; }

                /// <summary>
                /// 获取或设置是否开启水印访问人名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("show_visitor_name")]
                [System.Text.Json.Serialization.JsonPropertyName("show_visitor_name")]
                public bool? EnableShowVisitorName { get; set; }

                /// <summary>
                /// 获取或设置管理员是否强制要求使用水印。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("force_by_admin")]
                [System.Text.Json.Serialization.JsonPropertyName("force_by_admin")]
                public bool? IsForceByAdmin { get; set; }

                /// <summary>
                /// 获取或设置空间管理员是否强制要求使用水印。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("force_by_space_admin")]
                [System.Text.Json.Serialization.JsonPropertyName("force_by_space_admin")]
                public bool? IsForceBySpaceAdmin { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置文件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fileid")]
        [System.Text.Json.Serialization.JsonPropertyName("fileid")]
        public string FileId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置水印信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("watermark")]
        [System.Text.Json.Serialization.JsonPropertyName("watermark")]
        public Types.Watermark? Watermark { get; set; }
    }
}
