namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/poll/get_poll_list 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingPollGetPollListRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置操作者的 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("operator_userid")]
        public string OperatorUserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置终端设备类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instance_id")]
        [System.Text.Json.Serialization.JsonPropertyName("instance_id")]
        public int InstanceId { get; set; }
    }
}
