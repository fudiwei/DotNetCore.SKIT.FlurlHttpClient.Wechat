namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /password-exempt-contract/contracts/service-id/{service_id}/out-contract-code/{out_contract_code}/terminate 接口的请求。</para>
    /// </summary>
    public class TerminatePasswordExemptContractRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ServiceId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户签约协议号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutContractCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置解约备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_termination_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_termination_remark")]
        public string TerminationRemark { get; set; } = string.Empty;
    }
}
