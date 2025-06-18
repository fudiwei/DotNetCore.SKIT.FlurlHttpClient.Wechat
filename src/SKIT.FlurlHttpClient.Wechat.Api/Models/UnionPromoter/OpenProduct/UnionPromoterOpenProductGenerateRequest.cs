using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /union/promoter/open_product/generate 接口的请求。</para>
    /// </summary>
    public class UnionPromoterOpenProductGenerateRequest : WechatApiRequest, IInferable<UnionPromoterOpenProductGenerateRequest, UnionPromoterOpenProductGenerateResponse>
    {
        public static class Types
        {
            public class Product
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("productId")]
                [System.Text.Json.Serialization.JsonPropertyName("productId")]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置所属小商店 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appId")]
                [System.Text.Json.Serialization.JsonPropertyName("appId")]
                public string AppId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置自定义扩展参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("customizeInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("customizeInfo")]
                public string? CustomizeExtra { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置推广位 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pid")]
        [System.Text.Json.Serialization.JsonPropertyName("pid")]
        public string PromotionId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否拉取短链和推广文案。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("getShortUrl")]
        [System.Text.Json.Serialization.JsonPropertyName("getShortUrl")]
        public bool? RequireGetShortUrl { get; set; }

        /// <summary>
        /// 获取或设置是否拉取商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("getInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("getInfo")]
        public bool? RequireGetInfo { get; set; }

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("productList")]
        [System.Text.Json.Serialization.JsonPropertyName("productList")]
        public IList<Types.Product> ProductList { get; set; } = new List<Types.Product>();
    }
}
