namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/vip/user/list/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECVipUserListGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class VipInfo
            {
                public static class Types
                {
                    public class UserInfo
                    {
                        /// <summary>
                        /// 获取或设置手机号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("phone_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
                        public string PhoneNumber { get; set; } = default!;
                    }

                    public class UserGradeInfo
                    {
                        /// <summary>
                        /// 获取或设置会员等级。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("grade")]
                        [System.Text.Json.Serialization.JsonPropertyName("grade")]
                        public int Grade { get; set; }

                        /// <summary>
                        /// 获取或设置经验值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("experience_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("experience_value")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
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
                /// 获取或设置用户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_info")]
                [System.Text.Json.Serialization.JsonPropertyName("user_info")]
                public Types.UserInfo? UserInfo { get; set; }

                /// <summary>
                /// 获取或设置用户等级信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_grade_info")]
                [System.Text.Json.Serialization.JsonPropertyName("user_grade_info")]
                public Types.UserGradeInfo? UserGradeInfo { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.VipInfo[] VipList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
