namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchantfund/partner/income-records 接口的请求。</para>
    /// </summary>
    public class QueryMerchantFundPartnerIncomeRecordsRequest : QueryMerchantFundMerchantIncomeRecordsRequest
    {
        /// <summary>
        /// 获取或设置特约商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SubMerchantId { get; set; } = string.Empty;
    }
}
