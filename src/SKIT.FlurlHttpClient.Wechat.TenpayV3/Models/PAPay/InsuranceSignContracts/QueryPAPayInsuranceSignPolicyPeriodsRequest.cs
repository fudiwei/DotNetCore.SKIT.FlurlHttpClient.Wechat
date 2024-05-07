namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /papay/insurance-sign/policy_periods/plan-id/{plan_id}/out-contract-code/{out_contract_code} 接口的请求。</para>
    /// </summary>
    public class QueryPAPayInsuranceSignPolicyPeriodsRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long PlanId { get; set; }

        /// <summary>
        /// 获取或设置商户签约协议号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutContractCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分页大小。
        /// <para>默认值：20</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Limit { get; set; } = 20;

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Offset { get; set; }
    }
}
