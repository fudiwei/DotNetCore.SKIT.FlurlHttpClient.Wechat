using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/realcontrol/set_nicknames 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingRealControlSetNicknamesRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class OperatedUser : CgibinMeetingRealControlSetCoHostRequest.Types.OperatedUser
            {
                /// <summary>
                /// 获取或设置昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Nickname { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置被操作成员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operated_users")]
        [System.Text.Json.Serialization.JsonPropertyName("operated_users")]
        public IList<Types.OperatedUser> OperatedUser { get; set; } = new List<Types.OperatedUser>();
    }
}
