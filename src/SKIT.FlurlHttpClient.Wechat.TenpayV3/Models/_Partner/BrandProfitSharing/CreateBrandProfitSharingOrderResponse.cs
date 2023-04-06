namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /brand/profitsharing/orders 接口的响应。</para>
    /// </summary>
    public class CreateBrandProfitSharingOrderResponse : GetBrandProfitSharingOrderByOutOrderNumberResponse
    {
        /// <summary>
        /// 获取或设置品牌主商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_mchid")]
        public string BrandMerchantId { get; set; } = default!;
    }
}
