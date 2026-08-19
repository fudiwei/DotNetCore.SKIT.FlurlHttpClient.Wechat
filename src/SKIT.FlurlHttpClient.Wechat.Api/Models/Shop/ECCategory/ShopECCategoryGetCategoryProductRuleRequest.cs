namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/ec/category/getcategoryproductrule 接口的请求。</para>
    /// </summary>
    public class ShopECCategoryGetCategoryProductRuleRequest : WechatApiRequest, IInferable<ShopECCategoryGetCategoryProductRuleRequest, ShopECCategoryGetCategoryProductRuleResponse>
    {
        /// <summary>
        /// 获取或设置类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cat_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cat_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public long? BrandId { get; set; }

        /// <summary>
        /// 获取或设置发布模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("release_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("release_mode")]
        public int ReleaseMode { get; set; }
    }
}
