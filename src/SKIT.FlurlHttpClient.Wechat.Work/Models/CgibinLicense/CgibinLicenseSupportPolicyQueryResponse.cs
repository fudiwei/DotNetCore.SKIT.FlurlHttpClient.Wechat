namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/support_policy_query 接口的响应。</para>
    /// </summary>
    public class CgibinLicenseSupportPolicyQueryResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置查询结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_result")]
        [System.Text.Json.Serialization.JsonPropertyName("query_result")]
        public int QueryResult { get; set; }

        /// <summary>
        /// 获取或设置被查询企业不符合减免条件的原因对应的错误码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unsatisfied_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("unsatisfied_reason")]
        public int[]? UnsatisfiedReasonCodeList { get; set; }
    }
}
