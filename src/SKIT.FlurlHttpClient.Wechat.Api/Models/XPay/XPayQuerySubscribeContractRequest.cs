namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/query_subscribe_contract 接口的请求。</para>
    /// </summary>
    public class XPayQuerySubscribeContractRequest : XPayRequestBase, IInferable<XPayQuerySubscribeContractRequest, XPayQuerySubscribeContractResponse>
    {
        /// <summary>
        /// 获取或设置查询模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mode")]
        [System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string? Mode { get; set; }

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
            return "/xpay/query_subscribe_contract";
        }
    }
}
