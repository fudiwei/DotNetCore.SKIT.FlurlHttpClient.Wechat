namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/get_attendee_list 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingGetAttendeeListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Attendee
            {
                /// <summary>
                /// 获取或设置参与者成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置参与者临时 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tmp_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("tmp_openid")]
                public string? TempOpenId { get; set; }

                /// <summary>
                /// 获取或设置终端设备类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("instance_id")]
                [System.Text.Json.Serialization.JsonPropertyName("instance_id")]
                public int InstanceId { get; set; }

                /// <summary>
                /// 获取或设置成员角色。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("role")]
                [System.Text.Json.Serialization.JsonPropertyName("role")]
                public int Role { get; set; }

                /// <summary>
                /// 获取或设置入会方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("join_type")]
                [System.Text.Json.Serialization.JsonPropertyName("join_type")]
                public int JoinType { get; set; }

                /// <summary>
                /// 获取或设置加入会议时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("join_time")]
                [System.Text.Json.Serialization.JsonPropertyName("join_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long JoinTimestamp { get; set; }

                /// <summary>
                /// 获取或设置离开会议时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quit_time")]
                [System.Text.Json.Serialization.JsonPropertyName("quit_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? QuitTimestamp { get; set; }

                /// <summary>
                /// 获取或设置网络类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("net")]
                [System.Text.Json.Serialization.JsonPropertyName("net")]
                public string? NetType { get; set; }

                /// <summary>
                /// 获取或设置网络研讨会成员角色。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("webinar_role")]
                [System.Text.Json.Serialization.JsonPropertyName("webinar_role")]
                public int? WebinarRole { get; set; }

                /// <summary>
                /// 获取或设置是否开启麦克风。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audio_state")]
                [System.Text.Json.Serialization.JsonPropertyName("audio_state")]
                public bool IsAudioOpen { get; set; }

                /// <summary>
                /// 获取或设置是否开启摄像头。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_state")]
                [System.Text.Json.Serialization.JsonPropertyName("video_state")]
                public bool IsVideoOpen { get; set; }

                /// <summary>
                /// 获取或设置是否屏幕共享。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("screen_shared_state")]
                [System.Text.Json.Serialization.JsonPropertyName("screen_shared_state")]
                public bool IsScreenShared { get; set; }

                /// <summary>
                /// 获取或设置专属参会链接用户自定义数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("customer_data")]
                [System.Text.Json.Serialization.JsonPropertyName("customer_data")]
                public string? CustomData { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置参与者列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attendees")]
        [System.Text.Json.Serialization.JsonPropertyName("attendees")]
        public Types.Attendee[] AttendeeList { get; set; } = default!;

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
