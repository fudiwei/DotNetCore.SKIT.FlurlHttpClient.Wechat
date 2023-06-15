namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/record/list 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingRecordListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Record
            {
                public static class Types
                {
                    public class RecordFile
                    {
                        /// <summary>
                        /// 获取或设置录制文件 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("record_file_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("record_file_id")]
                        public string RecordFileId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置开始录制时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("record_start_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("record_start_time")]
                        public long RecordStartTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置结束录制时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("record_end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("record_end_time")]
                        public long RecordEndTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置文件大小（单位：字节）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("record_size")]
                        [System.Text.Json.Serialization.JsonPropertyName("record_size")]
                        public int FileSize { get; set; }

                        /// <summary>
                        /// 获取或设置共享状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sharing_state")]
                        [System.Text.Json.Serialization.JsonPropertyName("sharing_state")]
                        public int SharingState { get; set; }

                        /// <summary>
                        /// 获取或设置共享链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sharing_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("sharing_url")]
                        public string? SharingUrl { get; set; }

                        /// <summary>
                        /// 获取或设置是否仅企业成员可查看。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("required_same_corp")]
                        [System.Text.Json.Serialization.JsonPropertyName("required_same_corp")]
                        public bool? RequireSameCorp { get; set; }

                        /// <summary>
                        /// 获取或设置是否仅参会成员可查看。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("required_attendee")]
                        [System.Text.Json.Serialization.JsonPropertyName("required_attendee")]
                        public bool? RequireAttendee { get; set; }

                        /// <summary>
                        /// 获取或设置访问密码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("password")]
                        [System.Text.Json.Serialization.JsonPropertyName("password")]
                        public string? SharingPassword { get; set; }

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
                /// 获取或设置录制 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("meeting_record_id")]
                [System.Text.Json.Serialization.JsonPropertyName("meeting_record_id")]
                public string RecordId { get; set; } = default!;

                /// <summary>
                /// 获取或设置会议 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("meetingid")]
                [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
                public string MeetingId { get; set; } = default!;

                /// <summary>
                /// 获取或设置入会码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("meeting_code")]
                [System.Text.Json.Serialization.JsonPropertyName("meeting_code")]
                public string MeetingCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置会议主持人成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("host_user_id")]
                [System.Text.Json.Serialization.JsonPropertyName("host_user_id")]
                public string HostUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置会议主题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置会议开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("meeting_start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("meeting_start_time")]
                public long StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置录制状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                public int State { get; set; }

                /// <summary>
                /// 获取或设置录制文件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("record_files")]
                [System.Text.Json.Serialization.JsonPropertyName("record_files")]
                public Types.RecordFile[] RecordFileList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置录制列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record_meetings")]
        [System.Text.Json.Serialization.JsonPropertyName("record_meetings")]
        public Types.Record[] RecordList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
