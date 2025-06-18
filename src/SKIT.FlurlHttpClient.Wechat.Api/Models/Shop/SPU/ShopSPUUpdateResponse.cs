namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/spu/update 接口的响应。</para>
    /// </summary>
    public class ShopSPUUpdateResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data : ProductSPUUpdateResponse.Types.Data
            {
                public static class Types
                {
                    public class SKU : ShopSPUAddResponse.Types.Data.Types.SKU
                    {
                    }
                }

                /// <summary>
                /// 获取或设置 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skus")]
                [System.Text.Json.Serialization.JsonPropertyName("skus")]
                public Types.SKU[] SKUList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
