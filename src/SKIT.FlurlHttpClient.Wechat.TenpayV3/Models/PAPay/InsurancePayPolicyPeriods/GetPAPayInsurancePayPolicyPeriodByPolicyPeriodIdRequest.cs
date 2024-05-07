namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /papay/insurance-pay/policy-periods/contract-id/{contract_id}/policy-period-id/{policy_period_id} 接口的请求。</para>
    /// </summary>
    public class GetPAPayInsurancePayPolicyPeriodByPolicyPeriodIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置委托代扣签约协议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ContractId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置保单的扣费周期编号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int PolicyPeriodId { get; set; }
    }
}
