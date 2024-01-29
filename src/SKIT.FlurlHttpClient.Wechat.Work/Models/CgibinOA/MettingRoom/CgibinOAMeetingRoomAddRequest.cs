using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/meetingroom/add 接口的请求。</para>
    /// </summary>
    public class CgibinOAMeetingRoomAddRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Coordinate
            {
                /// <summary>
                /// 获取或设置经度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("longitude")]
                [System.Text.Json.Serialization.JsonPropertyName("longitude")]
                public decimal Longitude { get; set; }

                /// <summary>
                /// 获取或设置纬度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("latitude")]
                [System.Text.Json.Serialization.JsonPropertyName("latitude")]
                public decimal Latitude { get; set; }
            }

            public class Range
            {
                /// <summary>
                /// 获取或设置使用范围的成员 UserId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_list")]
                [System.Text.Json.Serialization.JsonPropertyName("user_list")]
                public IList<string>? UserIdList { get; set; }

                /// <summary>
                /// 获取或设置使用范围的部门 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("department_list")]
                [System.Text.Json.Serialization.JsonPropertyName("department_list")]
                public IList<long>? DepartmentId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会议室名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会议室容纳人数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("capacity")]
        [System.Text.Json.Serialization.JsonPropertyName("capacity")]
        public int Capacity { get; set; }

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
        /// 获取或设置使用范围信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("range")]
        [System.Text.Json.Serialization.JsonPropertyName("range")]
        public Types.Range? Range { get; set; }

        /// <summary>
        /// 获取或设置会议室支持的设备 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("equipment")]
        [System.Text.Json.Serialization.JsonPropertyName("equipment")]
        public IList<int>? EquipmentIdList { get; set; }
    }
}
