namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/realcontrol/set 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingRealControlSetRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否全体静音。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mute_all")]
        [System.Text.Json.Serialization.JsonPropertyName("mute_all")]
        public bool? IsMuteAll { get; set; }

        /// <summary>
        /// 获取或设置成员入会时静音模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_enter_mute")]
        [System.Text.Json.Serialization.JsonPropertyName("enable_enter_mute")]
        public int? EnterMuteMode { get; set; }

        /// <summary>
        /// 获取或设置允许参会者取消静音。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_unmute_self")]
        [System.Text.Json.Serialization.JsonPropertyName("allow_unmute_self")]
        public bool? AllowUnmuteSelf { get; set; }

        /// <summary>
        /// 获取或设置是否锁定会议。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_locked")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_locked")]
        public bool? IsMeetingLocked { get; set; }

        /// <summary>
        /// 获取或设置是否隐藏会议号和密码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hide_meeting_code_password")]
        [System.Text.Json.Serialization.JsonPropertyName("hide_meeting_code_password")]
        public bool? IsHideMeetingCodeAndPassword { get; set; }

        /// <summary>
        /// 获取或设置参会者聊天模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_chat")]
        [System.Text.Json.Serialization.JsonPropertyName("allow_chat")]
        public int? ChatMode { get; set; }

        /// <summary>
        /// 获取或设置是否允许参会者发起屏幕共享。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_share_screen")]
        [System.Text.Json.Serialization.JsonPropertyName("allow_share_screen")]
        public bool? AllowShareScreen { get; set; }

        /// <summary>
        /// 获取或设置是否允许外部成员入会。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_external_user")]
        [System.Text.Json.Serialization.JsonPropertyName("allow_external_user")]
        public bool? AllowExternalUser { get; set; }

        /// <summary>
        /// 获取或设置成员入会是否播放提示音。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("play_ivr_on_join")]
        [System.Text.Json.Serialization.JsonPropertyName("play_ivr_on_join")]
        public bool? EnablePlayIVROnJoin { get; set; }

        /// <summary>
        /// 获取或设置是否开启等候室。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_waiting_room")]
        [System.Text.Json.Serialization.JsonPropertyName("enable_waiting_room")]
        public bool? EnableWaitingRoom { get; set; }
    }
}
