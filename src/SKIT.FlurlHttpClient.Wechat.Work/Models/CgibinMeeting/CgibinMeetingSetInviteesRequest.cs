using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/set_invitees 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingSetInviteesRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Invitee
            {
                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置参与者列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invitees")]
        [System.Text.Json.Serialization.JsonPropertyName("invitees")]
        public IList<Types.Invitee> InviteeList { get; set; } = new List<Types.Invitee>();
    }
}
