namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /taxi-invoice/taxi-companies/{company_mchid} 接口的请求。</para>
    /// </summary>
    public class GetTaxiInvoiceTaxiCompanyRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置公司商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CompanyMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置行政区划代码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int RegionId { get; set; }
    }
}
