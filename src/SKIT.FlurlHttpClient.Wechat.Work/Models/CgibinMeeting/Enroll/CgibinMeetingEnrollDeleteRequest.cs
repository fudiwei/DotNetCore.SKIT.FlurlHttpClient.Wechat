using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/enroll/delete 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingEnrollDeleteRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Enroll
            {
                /// <summary>
                /// 获取或设置报名 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enroll_id")]
                [System.Text.Json.Serialization.JsonPropertyName("enroll_id")]
                public string EnrollId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置报名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enroll_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("enroll_id_list")]
        public IList<Types.Enroll> EnrollList { get; set; } = new List<Types.Enroll>();
    }
}
