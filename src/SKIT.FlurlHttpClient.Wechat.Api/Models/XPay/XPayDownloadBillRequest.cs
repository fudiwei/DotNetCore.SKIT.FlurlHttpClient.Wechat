namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/download_bill 接口的请求。</para>
    /// </summary>
    public class XPayDownloadBillRequest : XPayRequestBase, IInferable<XPayDownloadBillRequest, XPayDownloadBillResponse>
    {
        /// <summary>
        /// 获取或设置起始日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_ds")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_ds")]
        public string BeginDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置截止日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_ds")]
        [System.Text.Json.Serialization.JsonPropertyName("end_ds")]
        public string EndDateString { get; set; } = string.Empty;

        protected internal override string GetRequestPath()
        {
            return "/xpay/download_bill";
        }
    }
}
