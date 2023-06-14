using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/set_guests 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingSetGuestsRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Guest : CgibinMeetingCreateRequest.Types.Guest
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
        /// 获取或设置嘉宾列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guests")]
        [System.Text.Json.Serialization.JsonPropertyName("guests")]
        public IList<Types.Guest> GuestList { get; set; } = new List<Types.Guest>();
    }
}
