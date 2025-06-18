using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/devicedata/add_accesscontrol_rule 接口的请求。</para>
    /// </summary>
    public class CgibinDeviceDataAddAccessControlRuleRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class PassRule
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
                        public string OpenUserId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置成员类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_type")]
                        public int? UserType { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置门禁放行规则列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rule_list")]
                [System.Text.Json.Serialization.JsonPropertyName("rule_list")]
                public IList<string> RuleList { get; set; } = new List<string>();

                /// <summary>
                /// 获取或设置生效成员列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("effect_open_userid_list")]
                [System.Text.Json.Serialization.JsonPropertyName("effect_open_userid_list")]
                public IList<Types.EffectUser> EffectUserList { get; set; } = new List<Types.EffectUser>();
            }
        }

        /// <summary>
        /// 获取或设置门禁规则名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_name")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_name")]
        public string RuleName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置设备序列号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_sn_list")]
        [System.Text.Json.Serialization.JsonPropertyName("device_sn_list")]
        public IList<string> DeviceSerialNumberList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置门禁规则。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pass_rule")]
        [System.Text.Json.Serialization.JsonPropertyName("pass_rule")]
        public Types.PassRule? PassRule { get; set; }

        /// <summary>
        /// 获取或设置远程门禁规则。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remote_pass_rule")]
        [System.Text.Json.Serialization.JsonPropertyName("remote_pass_rule")]
        public Types.PassRule? RemotePassRule { get; set; }
    }
}
