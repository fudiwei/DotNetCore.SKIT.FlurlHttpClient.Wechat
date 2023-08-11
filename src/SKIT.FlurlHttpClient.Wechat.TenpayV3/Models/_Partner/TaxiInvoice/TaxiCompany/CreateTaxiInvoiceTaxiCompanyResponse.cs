namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /taxi-invoice/taxi-company/create-taxi-company 接口的响应。</para>
    /// </summary>
    public class CreateTaxiInvoiceTaxiCompanyResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置公司商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string CompanyMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置公司名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_name")]
        [System.Text.Json.Serialization.JsonPropertyName("company_name")]
        public string CompanyName { get; set; } = default!;
    }
}
