namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/record/update_sharing_config 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingRecordUpdateSharingConfigRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class SharingConfig
            {
                /// <summary>
                /// 获取或设置是否开启共享。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_sharing")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_sharing")]
                public bool EnableSharing { get; set; }

                /// <summary>
                /// 获取或设置共享权限类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sharing_auth_type")]
                [System.Text.Json.Serialization.JsonPropertyName("sharing_auth_type")]
                public int? SharingAuthType { get; set; }

                /// <summary>
                /// 获取或设置是否需要访问密码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_password")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_password")]
                public bool? EnablePassword { get; set; }

                /// <summary>
                /// 获取或设置访问密码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("password")]
                [System.Text.Json.Serialization.JsonPropertyName("password")]
                public string? SharingPassword { get; set; }

                /// <summary>
                /// 获取或设置是否有有效期。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_sharing_expire")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_sharing_expire")]
                public bool? EnableExpire { get; set; }

                /// <summary>
                /// 获取或设置共享链接过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sharing_expire")]
                [System.Text.Json.Serialization.JsonPropertyName("sharing_expire")]
                public long? SharingExpireTimestamp { get; set; }

                /// <summary>
                /// 获取或设置是否允许下载。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("allow_download")]
                [System.Text.Json.Serialization.JsonPropertyName("allow_download")]
                public bool? AllowDownload { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会议录制 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_record_id")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_record_id")]
        public string RecordId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置共享配置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharing_config")]
        [System.Text.Json.Serialization.JsonPropertyName("sharing_config")]
        public Types.SharingConfig SharingConfig { get; set; } = new Types.SharingConfig();
    }
}
