namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/meetingroom/list 接口的响应。</para>
    /// </summary>
    public class CgibinOAMeetingRoomListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class MeetingRoom
            {
                public static class Types
                {
                    public class Coordinate : CgibinOAMeetingRoomAddRequest.Types.Coordinate
                    {
                    }

                    public class Range
                    {
                        /// <summary>
                        /// 获取或设置使用范围的成员 UserId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_list")]
                        public string[]? UserIdList { get; set; }

                        /// <summary>
                        /// 获取或设置使用范围的部门 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("department_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("department_list")]
                        public long[]? DepartmentId { get; set; }
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
                public string Name { get; set; } = default!;

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
                public int[]? EquipmentIdList { get; set; }

                /// <summary>
                /// 获取或设置是否需要审批。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("need_approval")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("need_approval")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool RequireApproval { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会议室列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingroom_list")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingroom_list")]
        public Types.MeetingRoom[] MeetingRoomList { get; set; } = default!;
    }
}
