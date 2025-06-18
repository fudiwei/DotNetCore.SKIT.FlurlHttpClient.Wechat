using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/realcontrol/kickout_users 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingRealControlKickoutUsersRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class OperatedUser : CgibinMeetingRealControlSetCoHostRequest.Types.OperatedUser
            {
            }
        }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否允许其再次加入会议。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_rejoin")]
        [System.Text.Json.Serialization.JsonPropertyName("allow_rejoin")]
        public bool? AllowRejoin { get; set; }

        /// <summary>
        /// 获取或设置被操作成员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operated_users")]
        [System.Text.Json.Serialization.JsonPropertyName("operated_users")]
        public IList<Types.OperatedUser> OperatedUser { get; set; } = new List<Types.OperatedUser>();
    }
}
