using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/contactrule/delete 接口的请求。</para>
    /// </summary>
    public class CgibinContactRuleDeleteRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置规则 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_ids")]
        public IList<long> RuleIdList { get; set; } = new List<long>();
    }
}
