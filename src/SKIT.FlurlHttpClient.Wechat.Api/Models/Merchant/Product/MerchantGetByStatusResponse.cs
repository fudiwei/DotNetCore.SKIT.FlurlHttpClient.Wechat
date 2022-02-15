namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/getbystatus 接口的响应。</para>
    /// </summary>
    public class MerchantGetByStatusResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product : MerchantGetResponse.Types.Product
            {
                /// <summary>
                /// 获取或设置商品状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("products_info")]
        [System.Text.Json.Serialization.JsonPropertyName("products_info")]
        public Types.Product[] ProductList { get; set; } = default!;
    }
}
