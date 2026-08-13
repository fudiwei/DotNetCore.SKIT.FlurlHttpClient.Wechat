namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/send_subscribe_pre_payment 接口的请求。</para>
    /// </summary>
    public class XPaySendSubscribePrepaymentRequest : XPayRequestBase, IInferable<XPaySendSubscribePrepaymentRequest, XPaySendSubscribePrepaymentResponse>
    {
        /// <summary>
        /// 获取或设置道具 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public string ProductId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置道具价格（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deduct_price")]
        [System.Text.Json.Serialization.JsonPropertyName("deduct_price")]
        public int DeductPrice { get; set; }

        /// <summary>
        /// 获取或设置商家签约协议号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_contract_code")]
        [System.Text.Json.Serialization.JsonPropertyName("out_contract_code")]
        public string OutContractCode { get; set; } = string.Empty;

        protected internal override string GetRequestPath()
        {
            return "/xpay/send_subscribe_pre_payment";
        }
    }
}
