namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/goods-subsidy-activity/retail-store-act/{brand_id}/stores/{store_code} 接口的响应。</para>
    /// </summary>
    public class GetMarketingGoodsSubsidyActivityRetailStoreByStoreCodeResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置门店编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_code")]
        [System.Text.Json.Serialization.JsonPropertyName("store_code")]
        public string StoreCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置门店名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_name")]
        [System.Text.Json.Serialization.JsonPropertyName("store_name")]
        public string StoreName { get; set; } = default!;
    }
}
