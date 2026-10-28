namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/openhw/device/get_userinfo_by_ids 接口的响应。</para>
    /// </summary>
    public class CgibinOpenHardwareDeviceGetUserInfoByIdsResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class UserList
            {
                /// <summary>
                /// 获取或设置成员列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("useritems")]
                [System.Text.Json.Serialization.JsonPropertyName("useritems")]
                public List<Types.UserItem>? Items { get; set; }
            }

            public class UserItem : CgibinOpenHardwareDeviceGetUserInfoByPageResponse.Types.UserItem
            {
                public static new class Types
                {
                    public class PassRuleList
                    {
                        /// <summary>
                        /// 获取或设置门禁规则列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rule_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("rule_list")]
                        public List<Types.PassRuleItem>? Items { get; set; }
                    }

                    public class PassRuleItem : CgibinOpenHardwareDeviceGetUserInfoByPageResponse.Types.UserItem.Types.PassRuleItem
                    {
                    }
                }

                /// <summary>
                /// 获取或设置门禁规则列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pass_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("pass_rule")]
                public new Types.PassRuleList? PassRuleList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置成员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userinfo")]
        [System.Text.Json.Serialization.JsonPropertyName("userinfo")]
        public Types.UserList? UserList { get; set; }
    }
}
