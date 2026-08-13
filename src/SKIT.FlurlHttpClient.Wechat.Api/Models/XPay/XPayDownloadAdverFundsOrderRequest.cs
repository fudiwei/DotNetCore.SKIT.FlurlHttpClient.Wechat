namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/download_adverfunds_order 接口的请求。</para>
    /// </summary>
    public class XPayDownloadAdverFundsOrderRequest : XPayRequestBase, IInferable<XPayDownloadAdverFundsOrderRequest, XPayDownloadAdverFundsOrderResponse>
    {
        /// <summary>
        /// 获取或设置广告金发放 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fund_id")]
        [System.Text.Json.Serialization.JsonPropertyName("fund_id")]
        public string FundId { get; set; } = string.Empty;

        protected internal override string GetRequestPath()
        {
            return "/xpay/download_adverfunds_order";
        }
    }
}
