namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/goods-subsidy-activity/retail-store-act/{brand_id}/stores/{store_code} 接口的请求。</para>
    /// </summary>
    public class GetMarketingGoodsSubsidyActivityRetailStoreByStoreCodeRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BrandId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店编码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string StoreCode { get; set; } = string.Empty;
    }
}
