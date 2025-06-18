using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /papay/insurance-sign/contracts/plan-id/{plan_id}/contract-id/{contract_id}/renew 接口的请求。</para>
    /// </summary>
    public class RenewPAPayInsuranceSignContractRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Amount : PresignPAPayInsuranceSignContractEntrustJsapiRequest.Types.Amount
            {
            }

            public class PolicyPeriod : PresignPAPayInsuranceSignContractEntrustJsapiRequest.Types.PolicyPeriod
            {
            }
        }

        /// <summary>
        /// 获取或设置委托代扣签约协议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ContractId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long PlanId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置保险保单的扣费周期列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("policy_periods")]
        [System.Text.Json.Serialization.JsonPropertyName("policy_periods")]
        public IList<Types.PolicyPeriod>? PolicyPeriodList { get; set; }
    }
}
