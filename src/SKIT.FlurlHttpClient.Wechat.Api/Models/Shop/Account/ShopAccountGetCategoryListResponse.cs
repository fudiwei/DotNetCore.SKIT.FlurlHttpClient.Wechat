namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/account/get_category_list 接口的响应。</para>
    /// </summary>
    public class ShopAccountGetCategoryListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Category : ShopCategoryGetResponse.Types.Category
            {
            }
        }

        /// <summary>
        /// 获取或设置类目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Category[] CategoryList { get; set; } = default!;
    }
}
