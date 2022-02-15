using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/meetingroom/edit 接口的请求。</para>
    /// </summary>
    public class CgibinOAMeetingRoomEditRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Coordinate : CgibinOAMeetingRoomAddRequest.Types.Coordinate
            {
            }
        }

        /// <summary>
        /// 获取或设置会议室 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingroom_id")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingroom_id")]
        public int MeetingRoomId { get; set; }

        /// <summary>
        /// 获取或设置会议室名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 获取或设置会议室容纳人数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("capacity")]
        [System.Text.Json.Serialization.JsonPropertyName("capacity")]
        public int? Capacity { get; set; }

        /// <summary>
        /// 获取或设置会议室所在城市。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city")]
        [System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// 获取或设置会议室所在楼宇。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("building")]
        [System.Text.Json.Serialization.JsonPropertyName("building")]
        public string? Building { get; set; }

        /// <summary>
        /// 获取或设置会议室所在楼层。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("floor")]
        [System.Text.Json.Serialization.JsonPropertyName("floor")]
        public string? Floor { get; set; }

        /// <summary>
        /// 获取或设置会议室所在建筑经纬度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coordinate")]
        [System.Text.Json.Serialization.JsonPropertyName("coordinate")]
        public Types.Coordinate? Coordinate { get; set; }

        /// <summary>
        /// 获取或设置会议室支持的设备 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("equipment")]
        [System.Text.Json.Serialization.JsonPropertyName("equipment")]
        public IList<int>? EquipmentIdList { get; set; }
    }
}
