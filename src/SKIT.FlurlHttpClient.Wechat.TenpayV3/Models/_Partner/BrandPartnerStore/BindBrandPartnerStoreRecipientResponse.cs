namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /brand/partner/store/brandstores/{store_id}/bindrecipient 接口的响应。</para>
    /// </summary>
    public class BindBrandPartnerStoreRecipientResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_id")]
        [System.Text.Json.Serialization.JsonPropertyName("store_id")]
        public string StoreId { get; set; } = default!;

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string BrandId { get; set; } = default!;

        /// <summary>
        /// 获取或设置门店收款商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置门店收款主体。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_name")]
        [System.Text.Json.Serialization.JsonPropertyName("company_name")]
        public string CompanyName { get; set; } = default!;

        /// <summary>
        /// 获取或设置收款绑定状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recipient_state")]
        [System.Text.Json.Serialization.JsonPropertyName("recipient_state")]
        public string RecipientState { get; set; } = default!;
    }
}
