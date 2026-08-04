namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/contactrule/update 接口的响应。</para>
    /// </summary>
    public class CgibinContactRuleUpdateResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Rule : CgibinContactRuleListResponse.Types.Rule
            {
            }
        }

        /// <summary>
        /// 获取或设置规则列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rules")]
        [System.Text.Json.Serialization.JsonPropertyName("rules")]
        public Types.Rule[] RuleList { get; set; } = default!;
    }
}
