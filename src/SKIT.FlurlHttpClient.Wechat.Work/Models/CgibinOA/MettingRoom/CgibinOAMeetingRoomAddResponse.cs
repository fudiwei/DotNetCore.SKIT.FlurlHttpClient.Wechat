namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/meetingroom/add 接口的响应。</para>
    /// </summary>
    public class CgibinOAMeetingRoomAddResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置会议室 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingroom_id")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingroom_id")]
        public int MeetingRoomId { get; set; }
    }
}
