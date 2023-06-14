namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/check_device_in_meeting 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingCheckDeviceInMeetingResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置会议 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("meetingid")]
                [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
                public string MeetingId { get; set; } = default!;

                /// <summary>
                /// 获取或设置终端设备类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("instance_id")]
                [System.Text.Json.Serialization.JsonPropertyName("instance_id")]
                public int InstanceId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_list")]
        [System.Text.Json.Serialization.JsonPropertyName("result_list")]
        public Types.Result[] ResultList { get; set; } = default!;
    }
}
