namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/download_ios_settlement_bill 接口的请求。</para>
    /// </summary>
    public class XPayDownloadIOSSettlementBillRequest : XPayRequestBase, IInferable<XPayDownloadIOSSettlementBillRequest, XPayDownloadIOSSettlementBillResponse>
    {
        /// <summary>
        /// 获取或设置开始月份字符串（格式：yyyyMM）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_month")]
        [System.Text.Json.Serialization.JsonPropertyName("start_month")]
        public string StartMonthString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置结束月份字符串（格式：yyyyMM）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_month")]
        [System.Text.Json.Serialization.JsonPropertyName("end_month")]
        public string EndMonthString { get; set; } = string.Empty;

        protected internal override string GetRequestPath()
        {
            return "/xpay/download_ios_settlement_bill";
        }
    }
}
