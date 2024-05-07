namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /ecommerce/combine-papay/contracts/plan-id/{plan_id}/out-contract-code/{out_contract_code} 接口的请求。</para>
    /// </summary>
    public class GetEcommerceCombinePAPayContractByOutContractCodeRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long PlanId { get; set; }

        /// <summary>
        /// 获取或设置商户侧签约协议号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutContractCode { get; set; } = string.Empty;
    }
}
