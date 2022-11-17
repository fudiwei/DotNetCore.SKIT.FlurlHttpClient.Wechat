namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/devicedata/get_accesscontrol_rule 接口的响应。</para>
    /// </summary>
    public class CgibinDeviceDataGetAccessControlRuleResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class PassRuleList
            {
                /// <summary>
                /// 获取或设置门禁规则列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("items")]
                [System.Text.Json.Serialization.JsonPropertyName("items")]
                public Types.PassRuleItem[] Items { get; set; } = default!;
            }

            public class PassRuleItem
            {
                public static class Types
                {
                    public class EffectUser
                    {
                        /// <summary>
                        /// 获取或设置成员的 OpenUserId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_userid")]
                        public string OpenUserId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置成员类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_type")]
                        public int? UserType { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置门禁规则 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rule_id")]
                [System.Text.Json.Serialization.JsonPropertyName("rule_id")]
                public string RuleId { get; set; } = default!;

                /// <summary>
                /// 获取或设置门禁规则名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string RuleName { get; set; } = default!;

                /// <summary>
                /// 获取或设置门禁放行规则列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rule_list")]
                [System.Text.Json.Serialization.JsonPropertyName("rule_list")]
                public string[] RuleList { get; set; } = default!;

                /// <summary>
                /// 获取或设置生效成员列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("effect_open_userid_list")]
                [System.Text.Json.Serialization.JsonPropertyName("effect_open_userid_list")]
                public Types.EffectUser[] EffectUserList { get; set; } = default!;

                /// <summary>
                /// 获取或设置门禁生效时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("effect_time")]
                [System.Text.Json.Serialization.JsonPropertyName("effect_time")]
                public long EffectTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置门禁规则列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pass_rule")]
        [System.Text.Json.Serialization.JsonPropertyName("pass_rule")]
        public Types.PassRuleList? PassRuleList { get; set; }

        /// <summary>
        /// 获取或设置远程门禁规则列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remote_pass_rule")]
        [System.Text.Json.Serialization.JsonPropertyName("remote_pass_rule")]
        public Types.PassRuleList? RemotePassRuleList { get; set; }
    }
}
