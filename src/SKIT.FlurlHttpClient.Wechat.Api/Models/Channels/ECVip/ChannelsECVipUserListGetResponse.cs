namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/vip/user/list/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECVipUserListGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class User
            {
                public static class Types
                {
                    public class GradeInfo
                    {
                        /// <summary>
                        /// 获取或设置等级。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("grade")]
                        [System.Text.Json.Serialization.JsonPropertyName("grade")]
                        public int Grade { get; set; }

                        /// <summary>
                        /// 获取或设置经验值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("experience_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("experience_value")]
                        public int ExperienceValue { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置用户的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户的 UnionId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unionid")]
                [System.Text.Json.Serialization.JsonPropertyName("unionid")]
                public string? UnionId { get; set; }

                /// <summary>
                /// 获取或设置用户等级信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_grade_info")]
                [System.Text.Json.Serialization.JsonPropertyName("user_grade_info")]
                public Types.GradeInfo? GradeInfo { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.User[] UserList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
