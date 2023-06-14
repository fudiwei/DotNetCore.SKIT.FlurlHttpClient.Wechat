using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/enroll/approve 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingEnrollApproveRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置审批动作。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public int ActionType { get; set; }

        /// <summary>
        /// 获取或设置报名 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enroll_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("enroll_id_list")]
        public IList<string> EnrollIdList { get; set; } = new List<string>();
    }
}
