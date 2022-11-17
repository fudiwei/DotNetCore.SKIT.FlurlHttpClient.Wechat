using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/devicedata/mod_accesscontrol_rule 接口的请求。</para>
    /// </summary>
    public class CgibinDeviceDataModifyAccessControlRuleRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class PassRule : CgibinDeviceDataAddAccessControlRuleRequest.Types.PassRule
            {
            }
        }

        /// <summary>
        /// 获取或设置门禁规则 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_id")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_id")]
        public string RuleId { get; set; } = string.Empty;

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
