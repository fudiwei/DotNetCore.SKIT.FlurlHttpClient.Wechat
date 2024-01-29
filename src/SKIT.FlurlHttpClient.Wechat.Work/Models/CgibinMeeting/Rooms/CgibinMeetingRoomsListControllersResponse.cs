namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/rooms/list_controllers 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingRoomsListControllersResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Controller
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
                /// 获取或设置厂商名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("manufacture_name")]
                [System.Text.Json.Serialization.JsonPropertyName("manufacture_name")]
                public string ManufactureName { get; set; } = default!;

                /// <summary>
                /// 获取或设置控制器名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("controller_name")]
                [System.Text.Json.Serialization.JsonPropertyName("controller_name")]
                public string ControllerName { get; set; } = default!;

                /// <summary>
                /// 获取或设置控制器型号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("controller_model")]
                [System.Text.Json.Serialization.JsonPropertyName("controller_model")]
                public string ControllerModel { get; set; } = default!;

                /// <summary>
                /// 获取或设置应用版本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_version")]
                [System.Text.Json.Serialization.JsonPropertyName("app_version")]
                public string AppVersion { get; set; } = default!;

                /// <summary>
                /// 获取或设置固件版本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("framework_version")]
                [System.Text.Json.Serialization.JsonPropertyName("framework_version")]
                public string FrameworkVersion { get; set; } = default!;

                /// <summary>
                /// 获取或设置设备状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string ControllerStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置 IP 地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ip_address")]
                [System.Text.Json.Serialization.JsonPropertyName("ip_address")]
                public string IpAddress { get; set; } = default!;

                /// <summary>
                /// 获取或设置 MAC 地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mac_address")]
                [System.Text.Json.Serialization.JsonPropertyName("mac_address")]
                public string MacAddress { get; set; } = default!;

                /// <summary>
                /// 获取或设置 CPU 类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cpu_type")]
                [System.Text.Json.Serialization.JsonPropertyName("cpu_type")]
                public string CPUType { get; set; } = default!;

                /// <summary>
                /// 获取或设置 CPU 占用。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cpu_usage")]
                [System.Text.Json.Serialization.JsonPropertyName("cpu_usage")]
                public string CPUUsage { get; set; } = default!;

                /// <summary>
                /// 获取或设置网络类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("network_type")]
                [System.Text.Json.Serialization.JsonPropertyName("network_type")]
                public string NetworkType { get; set; } = default!;

                /// <summary>
                /// 获取或设置内存占用。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mem_usage")]
                [System.Text.Json.Serialization.JsonPropertyName("mem_usage")]
                public string MemoryUsage { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置控制器列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("controller_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("controller_info_list")]
        public Types.Controller[] ControllerList { get; set; } = default!;

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
