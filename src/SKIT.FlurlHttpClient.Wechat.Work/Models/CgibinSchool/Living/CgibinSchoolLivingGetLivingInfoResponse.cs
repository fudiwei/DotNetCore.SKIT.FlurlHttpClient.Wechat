namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/school/living/get_living_info 接口的响应。</para>
    /// </summary>
    public class CgibinSchoolLivingGetLivingInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Living
            {
                public static class Types
                {
                    public class LivingRange
                    {
                        /// <summary>
                        /// 获取或设置部门 ID（即班级）列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("partyids")]
                        [System.Text.Json.Serialization.JsonPropertyName("partyids")]
                        public int[]? DepartmentIdList { get; set; }

                        /// <summary>
                        /// 获取或设置客户群（即班级群）名称列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("group_names")]
                        [System.Text.Json.Serialization.JsonPropertyName("group_names")]
                        public string[]? GroupChatNameList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置主播成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("anchor_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("anchor_userid")]
                public string AnchorUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置直播标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("theme")]
                [System.Text.Json.Serialization.JsonPropertyName("theme")]
                public string Theme { get; set; } = default!;

                /// <summary>
                /// 获取或设置直播开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("living_start")]
                [System.Text.Json.Serialization.JsonPropertyName("living_start")]
                public long StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置直播持续时长（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("living_duration")]
                [System.Text.Json.Serialization.JsonPropertyName("living_duration")]
                public int Duration { get; set; }

                /// <summary>
                /// 获取或设置直播范围。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("living_range")]
                [System.Text.Json.Serialization.JsonPropertyName("living_range")]
                public Types.LivingRange Range { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否开启回放。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_replay")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("open_replay")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsOpenReplay { get; set; }

                /// <summary>
                /// 获取或设置观众总人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("viewer_num")]
                [System.Text.Json.Serialization.JsonPropertyName("viewer_num")]
                public int ViewerCount { get; set; }

                /// <summary>
                /// 获取或设置评论数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("comment_num")]
                [System.Text.Json.Serialization.JsonPropertyName("comment_num")]
                public int CommentCount { get; set; }

                /// <summary>
                /// 获取或设置推流地址 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("push_stream_url")]
                [System.Text.Json.Serialization.JsonPropertyName("push_stream_url")]
                public string? PushStreamUrl { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置直播信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("living_info")]
        [System.Text.Json.Serialization.JsonPropertyName("living_info")]
        public Types.Living Living { get; set; } = default!;
    }
}
