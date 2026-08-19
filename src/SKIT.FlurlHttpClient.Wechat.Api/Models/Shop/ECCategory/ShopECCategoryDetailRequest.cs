namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/ec/category/detail 接口的请求。</para>
    /// </summary>
    public class ShopECCategoryDetailRequest : WechatApiRequest, IInferable<ShopECCategoryDetailRequest, ShopECCategoryDetailResponse>
    {
        /// <summary>
        /// 获取或设置类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cat_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cat_id")]
        public long CategoryId { get; set; }
    }
}
