namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /taxi-invoice/taxi/update-taxi 接口的请求。</para>
    /// </summary>
    public class UpdateTaxiInvoiceTaxiRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置公司商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string CompanyMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置公司名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_name")]
        [System.Text.Json.Serialization.JsonPropertyName("company_name")]
        public string CompanyName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置车牌号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plate_number")]
        [System.Text.Json.Serialization.JsonPropertyName("plate_number")]
        public string PlateNumber { get; set; } = string.Empty;

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
        /// 获取或设置开票标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invoice_flag")]
        [System.Text.Json.Serialization.JsonPropertyName("invoice_flag")]
        public string InvoiceFlag { get; set; } = string.Empty;
    }
}
