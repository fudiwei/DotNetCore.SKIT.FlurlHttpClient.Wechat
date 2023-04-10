namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /mse-pay/bill-downloads 接口的请求。</para>
    /// </summary>
    public class GetBillRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置账单日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billDate")]
        [System.Text.Json.Serialization.JsonPropertyName("billDate")]
        public string BillDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置账单类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billType")]
        [System.Text.Json.Serialization.JsonPropertyName("billType")]
        public string? BillType { get; set; }
    }
}
