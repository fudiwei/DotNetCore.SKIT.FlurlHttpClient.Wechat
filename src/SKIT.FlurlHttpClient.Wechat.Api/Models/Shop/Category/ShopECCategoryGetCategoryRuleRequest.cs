namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/ec/category/getcategoryrule 接口的请求。</para>
    /// </summary>
    public class ShopECCategoryGetCategoryRuleRequest : WechatApiRequest, IInferable<ShopECCategoryGetCategoryRuleRequest, ShopECCategoryGetCategoryRuleResponse>
    {
        /// <summary>
        /// 获取或设置规则 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int RuleId { get; set; }

        /// <summary>
        /// 获取或设置类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_id")]
        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
        public long CategoryId { get; set; }
    }
}
