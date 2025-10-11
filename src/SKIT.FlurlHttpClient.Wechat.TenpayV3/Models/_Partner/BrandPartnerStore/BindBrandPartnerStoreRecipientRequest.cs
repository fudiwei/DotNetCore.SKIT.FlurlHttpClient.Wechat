namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /brand/partner/store/brandstores/{store_id}/bindrecipient 接口的请求。</para>
    /// </summary>
    public class BindBrandPartnerStoreRecipientRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string StoreId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string BrandId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店收款商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店收款主体。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_name")]
        [System.Text.Json.Serialization.JsonPropertyName("company_name")]
        public string CompanyName { get; set; } = string.Empty;
    }
}
