namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/rooms/list_devices 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingRoomsListDevicesResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Device
            {
                public static class Types
                {
                    public class MonitorInfo
                    {
                        /// <summary>
                        /// 获取或设置摄像头状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("camera_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("camera_status")]
                        public bool CameraStatus { get; set; }

                        /// <summary>
                        /// 获取或设置麦克风状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("microphone_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("microphone_status")]
                        public bool MicrophoneStatus { get; set; }

                        /// <summary>
                        /// 获取或设置扬声器状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("speaker_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("speaker_status")]
                        public bool SpeakerStatus { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置 Rooms ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rooms_id")]
                [System.Text.Json.Serialization.JsonPropertyName("rooms_id")]
                public string RoomsId { get; set; } = default!;

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
                /// 获取或设置设备型号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_model")]
                [System.Text.Json.Serialization.JsonPropertyName("device_model")]
                public string DeviceModel { get; set; } = default!;

                /// <summary>
                /// 获取或设置应用版本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_version")]
                [System.Text.Json.Serialization.JsonPropertyName("app_version")]
                public string AppVersion { get; set; } = default!;

                /// <summary>
                /// 获取或设置会议室状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("meeting_room_status")]
                [System.Text.Json.Serialization.JsonPropertyName("meeting_room_status")]
                public int MeetingRoomStatus { get; set; }

                /// <summary>
                /// 获取或设置设备健康信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_monitor_info")]
                [System.Text.Json.Serialization.JsonPropertyName("device_monitor_info")]
                public Types.MonitorInfo MonitorInfo { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置设备列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("device_info_list")]
        public Types.Device[] DeviceList { get; set; } = default!;

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
