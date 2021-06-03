using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/get_user_meetingid 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingGetUserMeetingIdResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置会议 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid_list")]
        public string[] MeetingIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
