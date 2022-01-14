namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /scan/product/v2/getinfobypage 接口的响应。</para>
    /// </summary>
    public class ScanProductV2GetInfoByPageResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product : ScanProductV2GetInfoResponse.Types.Product
            {
            }
        }

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product")]
        [System.Text.Json.Serialization.JsonPropertyName("product")]
        public Types.Product[] ProductList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_context")]
        [System.Text.Json.Serialization.JsonPropertyName("page_context")]
        public string? NextPageContext { get; set; }
    }
}
