using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/contactrule/update 接口的请求。</para>
    /// </summary>
    public class CgibinContactRuleUpdateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Rule : CgibinContactRuleCreateRequest.Types.Rule
            {
                /// <summary>
                /// 获取或设置规则 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rule_id")]
                [System.Text.Json.Serialization.JsonPropertyName("rule_id")]
                public long RuleId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置规则列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rules")]
        [System.Text.Json.Serialization.JsonPropertyName("rules")]
        public IList<Types.Rule> RuleList { get; set; } = new List<Types.Rule>();
    }
}
