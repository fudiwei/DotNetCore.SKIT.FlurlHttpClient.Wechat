namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/rooms/get_config 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingRoomsGetConfigResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class MeetingSettings
            {
                /// <summary>
                /// 获取或设置水印状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("water_mark")]
                [System.Text.Json.Serialization.JsonPropertyName("water_mark")]
                public int WatermarkStatus { get; set; }

                /// <summary>
                /// 获取或设置自动接听状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auto_response")]
                [System.Text.Json.Serialization.JsonPropertyName("auto_response")]
                public int AutoResponseStatus { get; set; }

                /// <summary>
                /// 获取或设置是否开启字幕。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("caption")]
                [System.Text.Json.Serialization.JsonPropertyName("caption")]
                public bool EnableCaption { get; set; }

                /// <summary>
                /// 获取或设置是否开启专属 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("room_pmi")]
                [System.Text.Json.Serialization.JsonPropertyName("room_pmi")]
                public bool EnableRoomPMI { get; set; }

                /// <summary>
                /// 获取或设置是否展示消息通知。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("room_notification")]
                [System.Text.Json.Serialization.JsonPropertyName("room_notification")]
                public bool EnableRoomNotification { get; set; }
            }

            public class RecordSettings
            {
                /// <summary>
                /// 获取或设置分享云录制状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("share_record")]
                [System.Text.Json.Serialization.JsonPropertyName("share_record")]
                public int ShareRecordStatus { get; set; }

                /// <summary>
                /// 获取或设置是否允许下载云录制。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("download_record")]
                [System.Text.Json.Serialization.JsonPropertyName("download_record")]
                public bool AllowDownload { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会议配置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_settings")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_settings")]
        public Types.MeetingSettings MeetingSettings { get; set; } = default!;

        /// <summary>
        /// 获取或设置录制配置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record_settings")]
        [System.Text.Json.Serialization.JsonPropertyName("record_settings")]
        public Types.RecordSettings RecordSettings { get; set; } = default!;
    }
}
