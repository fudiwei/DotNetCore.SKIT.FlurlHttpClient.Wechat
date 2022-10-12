namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/devicedata/mod_accesscontrol_rule 接口的响应。</para>
    /// </summary>
    public class CgibinDeviceDataModifyAccessControlRuleResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置非法的 OpenUserId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_list")]
        public string[]? InvalidOpenUserIdList { get; set; }
    }
}
