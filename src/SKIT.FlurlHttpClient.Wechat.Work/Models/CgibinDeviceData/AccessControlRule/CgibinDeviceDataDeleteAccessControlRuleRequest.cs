namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/devicedata/del_accesscontrol_rule 接口的请求。</para>
    /// </summary>
    public class CgibinDeviceDataDeleteAccessControlRuleRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置门禁规则 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_id")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_id")]
        public string RuleId { get; set; } = string.Empty;
    }
}
