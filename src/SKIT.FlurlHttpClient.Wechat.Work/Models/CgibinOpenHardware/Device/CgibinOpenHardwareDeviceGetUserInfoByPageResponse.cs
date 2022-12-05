namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/openhw/device/get_userinfo_by_page 接口的响应。</para>
    /// </summary>
    public class CgibinOpenHardwareDeviceGetUserInfoByPageResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class UserList
            {
                /// <summary>
                /// 获取或设置用户列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("useritems")]
                [System.Text.Json.Serialization.JsonPropertyName("useritems")]
                public Types.UserItem[] Items { get; set; } = default!;
            }

            public class UserItem
            {
                public static class Types
                {
                    public class PassRuleList
                    {
                        /// <summary>
                        /// 获取或设置门禁规则列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rule_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("rule_list")]
                        public Types.PassRuleItem[] Items { get; set; } = default!;
                    }

                    public class PassRuleItem
                    {
                        /// <summary>
                        /// 获取或设置规则 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public long RuleId { get; set; }

                        /// <summary>
                        /// 获取或设置放行规则。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rule")]
                        [System.Text.Json.Serialization.JsonPropertyName("rule")]
                        public string Rule { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置生效时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("effect_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("effect_time")]
                        public long EffectTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置用户的 OpenUserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("open_userid")]
                public string OpenUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_type")]
                [System.Text.Json.Serialization.JsonPropertyName("user_type")]
                public int UserType { get; set; }

                /// <summary>
                /// 获取或设置用户名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_name")]
                [System.Text.Json.Serialization.JsonPropertyName("user_name")]
                public string UserName { get; set; } = default!;

                /// <summary>
                /// 获取或设置门禁规则列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pass_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("pass_rule")]
                public Types.PassRuleList? PassRuleList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置当前云端通讯录版本号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("perm_version")]
        [System.Text.Json.Serialization.JsonPropertyName("perm_version")]
        public int PermVersion { get; set; }

        /// <summary>
        /// 获取或设置用户列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userinfo")]
        [System.Text.Json.Serialization.JsonPropertyName("userinfo")]
        public Types.UserList UserList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
