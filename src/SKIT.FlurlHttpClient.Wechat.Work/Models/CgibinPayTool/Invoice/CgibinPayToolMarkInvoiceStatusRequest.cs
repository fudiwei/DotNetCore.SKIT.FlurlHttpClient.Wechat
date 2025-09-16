namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/paytool/mark_invoice_status 接口的请求。</para>
    /// </summary>
    public class CgibinPayToolMarkInvoiceStatusRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置服务商 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProviderAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开票订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置操作人的成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("oper_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("oper_userid")]
        public string? OperatorUserId { get; set; }

        /// <summary>
        /// 获取或设置开票状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invoice_status")]
        [System.Text.Json.Serialization.JsonPropertyName("invoice_status")]
        public int InvoiceStatus { get; set; }

        /// <summary>
        /// 获取或设置开票备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invoice_note")]
        [System.Text.Json.Serialization.JsonPropertyName("invoice_note")]
        public string InvoiceNotes { get; set; } = string.Empty;
    }
}
