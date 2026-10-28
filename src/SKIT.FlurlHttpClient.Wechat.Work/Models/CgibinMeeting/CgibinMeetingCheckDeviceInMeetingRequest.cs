namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/check_device_in_meeting 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingCheckDeviceInMeetingRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置用户成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string? UserId { get; set; }

        /// <summary>
        /// 获取或设置终端设备类型列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instance_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("instance_id_list")]
        public List<int>? InstanceIdList { get; set; }

        /// <summary>
        /// 获取或设置会议 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid_list")]
        public List<string>? MeetingIdList { get; set; }
    }
}
