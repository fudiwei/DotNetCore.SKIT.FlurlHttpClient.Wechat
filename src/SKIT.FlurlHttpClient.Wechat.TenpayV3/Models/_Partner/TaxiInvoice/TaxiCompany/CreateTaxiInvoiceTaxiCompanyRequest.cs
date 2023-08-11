namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /taxi-invoice/taxi-company/create-taxi-company 接口的请求。</para>
    /// </summary>
    public class CreateTaxiInvoiceTaxiCompanyRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置企业类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enterprise_type")]
        [System.Text.Json.Serialization.JsonPropertyName("enterprise_type")]
        public string EnterpriseType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置公司名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_name")]
        [System.Text.Json.Serialization.JsonPropertyName("company_name")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// 获取或设置公司简称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("short_name")]
        [System.Text.Json.Serialization.JsonPropertyName("short_name")]
        public string? ShortName { get; set; }

        /// <summary>
        /// 获取或设置税号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tax_id")]
        [System.Text.Json.Serialization.JsonPropertyName("tax_id")]
        public string TaxId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置企业法人姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("legal_person")]
        [System.Text.Json.Serialization.JsonPropertyName("legal_person")]
        public string LegalPerson { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置行政区划代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("region_id")]
        [System.Text.Json.Serialization.JsonPropertyName("region_id")]
        public int RegionId { get; set; }

        /// <summary>
        /// 获取或设置公司地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        [System.Text.Json.Serialization.JsonPropertyName("address")]
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置公司电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone")]
        [System.Text.Json.Serialization.JsonPropertyName("phone")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置开户银行。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_name")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
        public string? BankName { get; set; }

        /// <summary>
        /// 获取或设置银行账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_account")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_account")]
        public string? BankAccountNumber { get; set; }

        /// <summary>
        /// 获取或设置开票渠道。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invoice_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("invoice_mode")]
        public string InvoiceMode { get; set; } = string.Empty;
    }
}
