namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /taxi-invoice/taxies/{plate_number} 接口的响应。</para>
    /// </summary>
    public class GetTaxiInvoiceTaxiResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置公司商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("company_mchid")]
        public string CompanyMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置公司名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_name")]
        [System.Text.Json.Serialization.JsonPropertyName("company_name")]
        public string CompanyName { get; set; } = default!;

        /// <summary>
        /// 获取或设置车牌号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plate_number")]
        [System.Text.Json.Serialization.JsonPropertyName("plate_number")]
        public string PlateNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置主班司机资格证号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("main_license")]
        [System.Text.Json.Serialization.JsonPropertyName("main_license")]
        public string? MainLicenseNumber { get; set; }

        /// <summary>
        /// 获取或设置副班司机资格证号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deputy_license")]
        [System.Text.Json.Serialization.JsonPropertyName("deputy_license")]
        public string? DeputyLicenseNumber { get; set; }

        /// <summary>
        /// 获取或设置行政区划代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("region_id")]
        [System.Text.Json.Serialization.JsonPropertyName("region_id")]
        public int RegionId { get; set; }

        /// <summary>
        /// 获取或设置出租车状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taxi_state")]
        [System.Text.Json.Serialization.JsonPropertyName("taxi_state")]
        public string? TaxiState { get; set; }

        /// <summary>
        /// 获取或设置是否支持开票。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("support_invoice")]
        [System.Text.Json.Serialization.JsonPropertyName("support_invoice")]
        public bool IsSupportInvoice { get; set; }
    }
}
