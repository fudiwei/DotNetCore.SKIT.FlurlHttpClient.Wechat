namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/category/getproperty 接口的请求。</para>
    /// </summary>
    public class MerchantCategoryGetPropertyRequest : WechatApiRequest, IInferable<MerchantCategoryGetPropertyRequest, MerchantCategoryGetPropertyResponse>
    {
        /// <summary>
        /// 获取或设置商品分类 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cate_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cate_id")]
        public string CategoryId { get; set; } = string.Empty;
    }
}
