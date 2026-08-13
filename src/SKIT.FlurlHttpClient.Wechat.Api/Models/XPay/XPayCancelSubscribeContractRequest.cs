namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/cancel_subscribe_contract 接口的请求。</para>
    /// </summary>
    public class XPayCancelSubscribeContractRequest : XPayRequestBase, IInferable<XPayCancelSubscribeContractRequest, XPayCancelSubscribeContractResponse>
    {
        /// <summary>
        /// 获取或设置解约原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termination_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("termination_reason")]
        public string TerminationReason { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置道具 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public string ProductId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商家签约协议号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_contract_code")]
        [System.Text.Json.Serialization.JsonPropertyName("out_contract_code")]
        public string OutContractCode { get; set; } = string.Empty;

        protected internal override string GetRequestPath()
        {
            return "/xpay/cancel_subscribe_contract";
        }
    }
}
