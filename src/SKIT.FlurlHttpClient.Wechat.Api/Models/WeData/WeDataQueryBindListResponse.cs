namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wedata/wedata_query_bind_list 接口的响应。</para>
    /// </summary>
    public class WeDataQueryBindListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class UserInfo
            {
                public static class Types
                {
                    public class Permission : WeDataGetPermissionListResponse.Types.Permission
                    {
                    }
                }

                /// <summary>
                /// 获取或设置用户在服务商系统的唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("uid")]
                [System.Text.Json.Serialization.JsonPropertyName("uid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否绑定了微信号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_bind")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_bind")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsBind { get; set; }

                /// <summary>
                /// 获取或设置用户微信昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string? Nickname { get; set; }

                /// <summary>
                /// 获取或设置用户微信头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_url")]
                [System.Text.Json.Serialization.JsonPropertyName("head_url")]
                public string? HeadImageUrl { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置用户权限集列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("perm")]
                [System.Text.Json.Serialization.JsonPropertyName("perm")]
                public Types.Permission[]? PermissionList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户绑定信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.UserInfo[] UserList { get; set; } = default!;
    }
}
