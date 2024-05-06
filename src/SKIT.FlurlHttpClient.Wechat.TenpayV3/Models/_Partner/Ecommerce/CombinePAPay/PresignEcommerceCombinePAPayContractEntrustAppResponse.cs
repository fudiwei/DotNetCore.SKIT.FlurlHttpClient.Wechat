namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /ecommerce/combine-papay/contracts/pre-entrust-sign 接口的响应。</para>
    /// </summary>
    public class PresignEcommerceCombinePAPayContractEntrustAppResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_id")]
        public int PlanId { get; set; }

        /// <summary>
        /// 获取或设置商户签约协议号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_contract_code")]
        [System.Text.Json.Serialization.JsonPropertyName("out_contract_code")]
        public string OutContractCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置委托代扣签约会话 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pre_entrustweb_id")]
        [System.Text.Json.Serialization.JsonPropertyName("pre_entrustweb_id")]
        public string SessionId { get; set; } = default!;
    }
}
