namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /mse-pay/bill-downloads/trans 接口的请求。</para>
    /// </summary>
    public class GetBillTransactionRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置账单日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_Date")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_Date")]
        public string BillDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置账单类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_Type")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_Type")]
        public string? BillType { get; set; }

        /// <summary>
        /// 获取或设置企业 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ent_id")]
        public string? EnterpriseId { get; set; }
    }
}
