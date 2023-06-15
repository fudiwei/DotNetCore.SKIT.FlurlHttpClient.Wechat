namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/rooms/list 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingRoomsListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class MeetingRoom
            {
                /// <summary>
                /// 获取或设置会议室 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("meeting_room_id")]
                [System.Text.Json.Serialization.JsonPropertyName("meeting_room_id")]
                public string MeetingRoomId { get; set; } = default!;

                /// <summary>
                /// 获取或设置会议室名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("meeting_room_name")]
                [System.Text.Json.Serialization.JsonPropertyName("meeting_room_name")]
                public string MeetingRoomName { get; set; } = default!;

                /// <summary>
                /// 获取或设置会议室地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("meeting_room_location")]
                [System.Text.Json.Serialization.JsonPropertyName("meeting_room_location")]
                public string MeetingRoomLocation { get; set; } = default!;

                /// <summary>
                /// 获取或设置账号类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_type")]
                [System.Text.Json.Serialization.JsonPropertyName("account_type")]
                public int AccountType { get; set; }

                /// <summary>
                /// 获取或设置激活码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("active_code")]
                [System.Text.Json.Serialization.JsonPropertyName("active_code")]
                public string ActiveCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置容纳人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("participant_number")]
                [System.Text.Json.Serialization.JsonPropertyName("participant_number")]
                public int ParticipantNumber { get; set; }

                /// <summary>
                /// 获取或设置会议室状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("meeting_room_status")]
                [System.Text.Json.Serialization.JsonPropertyName("meeting_room_status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置预定状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scheduled_status")]
                [System.Text.Json.Serialization.JsonPropertyName("scheduled_status")]
                public int ScheduledStatus { get; set; }

                /// <summary>
                /// 获取或设置是否允许被呼叫。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_allow_call")]
                [System.Text.Json.Serialization.JsonPropertyName("is_allow_call")]
                public bool IsAllowCall { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会议室列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_room_list")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_room_list")]
        public Types.MeetingRoom[] MeetingRoomList { get; set; } = default!;

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
