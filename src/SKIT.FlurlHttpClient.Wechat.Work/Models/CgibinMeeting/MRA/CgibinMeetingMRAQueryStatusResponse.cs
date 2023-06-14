namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/mra/query_status 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingMRAQueryStatusResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置会议的成员临时 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tmp_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("tmp_openid")]
        public string TempOpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置终端设备类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instance_id")]
        [System.Text.Json.Serialization.JsonPropertyName("instance_id")]
        public int InstanceId { get; set; }

        /// <summary>
        /// 获取或设置成员角色。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_role")]
        [System.Text.Json.Serialization.JsonPropertyName("user_role")]
        public int UserRole { get; set; }

        /// <summary>
        /// 获取或设置网络研讨会成员角色。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webinar_member_role")]
        [System.Text.Json.Serialization.JsonPropertyName("webinar_member_role")]
        public int? WebinarMemberRole { get; set; }

        /// <summary>
        /// 获取或设置 IP 地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ip")]
        [System.Text.Json.Serialization.JsonPropertyName("ip")]
        public string? IpAddress { get; set; }

        /// <summary>
        /// 获取或设置显示名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? DisplayName { get; set; }

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
        /// 获取或设置默认分屏设置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("default_layout")]
        [System.Text.Json.Serialization.JsonPropertyName("default_layout")]
        public int DefaultLayout { get; set; }

        /// <summary>
        /// 获取或设置是否举手。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("raise_hands_state")]
        [System.Text.Json.Serialization.JsonPropertyName("raise_hands_state")]
        public bool IsRaiseHand { get; set; }
    }
}
