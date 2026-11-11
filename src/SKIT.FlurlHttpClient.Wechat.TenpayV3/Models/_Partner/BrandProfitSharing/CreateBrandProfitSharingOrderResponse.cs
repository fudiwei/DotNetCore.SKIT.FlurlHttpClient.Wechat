namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    using SKIT.FlurlHttpClient.Internal.CodeAnalysis;

    /// <summary>
    /// <para>表示 [POST] /brand/profitsharing/orders 接口的响应。</para>
    /// </summary>
    [DisallowAnalyzerRule("type-declaration/no-external-contract-nested-types", Addition = "SKIT.FlurlHttpClient.Wechat.TenpayV3.Models." + nameof(GetBrandProfitSharingOrderByOutOrderNumberResponse))]
    public class CreateBrandProfitSharingOrderResponse : GetBrandProfitSharingOrderByOutOrderNumberResponse
    {
        /// <summary>
        /// 获取或设置品牌主商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_mchid")]
        public string? BrandMerchantId { get; set; }
    }
}
