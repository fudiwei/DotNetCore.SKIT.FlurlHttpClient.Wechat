using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/meetingroom/get_booking_info 接口的请求。</para>
    /// </summary>
    public class CgibinOAMeetingRoomGetBookingInfoRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置指定会议室 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingroom_id")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingroom_id")]
        public int? MeetingRoomId { get; set; }

        /// <summary>
        /// 获取或设置指定预定开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置指定预定开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置指定城市。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city")]
        [System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// 获取或设置指定楼宇。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("building")]
        [System.Text.Json.Serialization.JsonPropertyName("building")]
        public string? Building { get; set; }

        /// <summary>
        /// 获取或设置指定楼层。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("floor")]
        [System.Text.Json.Serialization.JsonPropertyName("floor")]
        public string? Floor { get; set; }
    }
}
