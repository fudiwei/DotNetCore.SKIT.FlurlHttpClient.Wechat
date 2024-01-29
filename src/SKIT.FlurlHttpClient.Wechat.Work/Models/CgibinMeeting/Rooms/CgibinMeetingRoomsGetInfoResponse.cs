namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/rooms/get_info 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingRoomsGetInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class BasicInfo
            {
                /// <summary>
                /// 获取或设置 Rooms ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rooms_id_list")]
                [System.Text.Json.Serialization.JsonPropertyName("rooms_id_list")]
                public string[] RoomsIdList { get; set; } = default!;

                /// <summary>
                /// 获取或设置会议室名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("meeting_room_name")]
                [System.Text.Json.Serialization.JsonPropertyName("meeting_room_name")]
                public string MeetingRoomName { get; set; } = default!;

                /// <summary>
                /// 获取或设置城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                public string City { get; set; } = default!;

                /// <summary>
                /// 获取或设置建筑。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("building")]
                [System.Text.Json.Serialization.JsonPropertyName("building")]
                public string Building { get; set; } = default!;

                /// <summary>
                /// 获取或设置楼层。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("floor")]
                [System.Text.Json.Serialization.JsonPropertyName("floor")]
                public string Floor { get; set; } = default!;

                /// <summary>
                /// 获取或设置容纳人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("participant_number")]
                [System.Text.Json.Serialization.JsonPropertyName("participant_number")]
                public int ParticipantNumber { get; set; }

                /// <summary>
                /// 获取或设置会议室设备。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device")]
                [System.Text.Json.Serialization.JsonPropertyName("device")]
                public string? Device { get; set; }

                /// <summary>
                /// 获取或设置描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc")]
                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置管理员密码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("password")]
                [System.Text.Json.Serialization.JsonPropertyName("password")]
                public string? Password { get; set; }
            }

            public class AccountInfo
            {
                /// <summary>
                /// 获取或设置账号类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_type")]
                [System.Text.Json.Serialization.JsonPropertyName("account_type")]
                public int AccountType { get; set; }

                /// <summary>
                /// 获取或设置有效期限字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("valid_period")]
                [System.Text.Json.Serialization.JsonPropertyName("valid_period")]
                public string ValidPeriodString { get; set; } = default!;
            }

            public class HardwareInfo
            {
                /// <summary>
                /// 获取或设置厂家。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("factory")]
                [System.Text.Json.Serialization.JsonPropertyName("factory")]
                public string Factory { get; set; } = default!;

                /// <summary>
                /// 获取或设置设备型号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_model")]
                [System.Text.Json.Serialization.JsonPropertyName("device_model")]
                public string DeviceModel { get; set; } = default!;

                /// <summary>
                /// 获取或设置设备序列号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sn")]
                [System.Text.Json.Serialization.JsonPropertyName("sn")]
                public string SerialNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置 IP 地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ip")]
                [System.Text.Json.Serialization.JsonPropertyName("ip")]
                public string IpAddress { get; set; } = default!;

                /// <summary>
                /// 获取或设置 MAC 地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mac")]
                [System.Text.Json.Serialization.JsonPropertyName("mac")]
                public string MacAddress { get; set; } = default!;

                /// <summary>
                /// 获取或设置 Rooms 版本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rooms_version")]
                [System.Text.Json.Serialization.JsonPropertyName("rooms_version")]
                public string RoomsVersion { get; set; } = default!;

                /// <summary>
                /// 获取或设置固件版本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("firmware_version")]
                [System.Text.Json.Serialization.JsonPropertyName("firmware_version")]
                public string FirmwareVersion { get; set; } = default!;

                /// <summary>
                /// 获取或设置健康状况。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("health_status")]
                [System.Text.Json.Serialization.JsonPropertyName("health_status")]
                public string HealthStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置设备系统。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("system_type")]
                [System.Text.Json.Serialization.JsonPropertyName("system_type")]
                public string SystemType { get; set; } = default!;

                /// <summary>
                /// 获取或设置会议室状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("meeting_room_status")]
                [System.Text.Json.Serialization.JsonPropertyName("meeting_room_status")]
                public int MeetingRoomStatus { get; set; }

                /// <summary>
                /// 获取或设置激活时间字符串（格式：yyyy-MM-dd HH:mm:ss）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("active_time")]
                [System.Text.Json.Serialization.JsonPropertyName("active_time")]
                public string ActiveTimeString { get; set; } = default!;

                /// <summary>
                /// 获取或设置 CPU 信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cpu_info")]
                [System.Text.Json.Serialization.JsonPropertyName("cpu_info")]
                public string CPUInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置 CPU 占用。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cpu_usage")]
                [System.Text.Json.Serialization.JsonPropertyName("cpu_usage")]
                public string CPUUsage { get; set; } = default!;

                /// <summary>
                /// 获取或设置 GPU 信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("gpu_info")]
                [System.Text.Json.Serialization.JsonPropertyName("gpu_info")]
                public string GPUInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置网络类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("net_type")]
                [System.Text.Json.Serialization.JsonPropertyName("net_type")]
                public string NetworkType { get; set; } = default!;

                /// <summary>
                /// 获取或设置内存信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("memory_info")]
                [System.Text.Json.Serialization.JsonPropertyName("memory_info")]
                public string MemoryInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置显示器刷新率。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("monitor_frequency")]
                [System.Text.Json.Serialization.JsonPropertyName("monitor_frequency")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string MonitorFrequency { get; set; } = default!;

                /// <summary>
                /// 获取或设置摄像头型号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("camera_model")]
                [System.Text.Json.Serialization.JsonPropertyName("camera_model")]
                public string CameraModel { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否开启视频镜像。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_video_mirror")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_video_mirror")]
                public bool EnableVideoMirror { get; set; }

                /// <summary>
                /// 获取或设置麦克风信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("microphone_info")]
                [System.Text.Json.Serialization.JsonPropertyName("microphone_info")]
                public string MicrophoneInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置扬声器信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("speaker_info")]
                [System.Text.Json.Serialization.JsonPropertyName("speaker_info")]
                public string SpeakerInfo { get; set; } = default!;
            }

            public class PMIInfo
            {
                /// <summary>
                /// 获取或设置专属 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pmi_code")]
                [System.Text.Json.Serialization.JsonPropertyName("pmi_code")]
                public string PMICode { get; set; } = default!;

                /// <summary>
                /// 获取或设置入会密码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pmi_pwd")]
                [System.Text.Json.Serialization.JsonPropertyName("pmi_pwd")]
                public string PMIPassword { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置基本信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("basic_info")]
        [System.Text.Json.Serialization.JsonPropertyName("basic_info")]
        public Types.BasicInfo BasicInfo { get; set; } = default!;

        /// <summary>
        /// 获取或设置帐号信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_info")]
        [System.Text.Json.Serialization.JsonPropertyName("account_info")]
        public Types.AccountInfo AccountInfo { get; set; } = default!;

        /// <summary>
        /// 获取或设置硬件信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hardware_info")]
        [System.Text.Json.Serialization.JsonPropertyName("hardware_info")]
        public Types.HardwareInfo HardwareInfo { get; set; } = default!;

        /// <summary>
        /// 获取或设置 PMI 信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pmi_info")]
        [System.Text.Json.Serialization.JsonPropertyName("pmi_info")]
        public Types.PMIInfo PMIInfo { get; set; } = default!;

        /// <summary>
        /// 获取或设置告警通知状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("monitor_status")]
        [System.Text.Json.Serialization.JsonPropertyName("monitor_status")]
        public int MonitorStatus { get; set; }

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
