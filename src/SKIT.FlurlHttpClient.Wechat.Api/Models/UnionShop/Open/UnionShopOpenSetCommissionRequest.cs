using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /union/shop/open/set_commission 接口的请求。</para>
    /// </summary>
    public class UnionShopOpenSetCommissionRequest : WechatApiRequest, IInferable<UnionShopOpenSetCommissionRequest, UnionShopOpenSetCommissionResponse>
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
                public long? ProductId { get; set; }

                /// <summary>
                /// 获取或设置商家自定义商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("outProductId")]
                [System.Text.Json.Serialization.JsonPropertyName("outProductId")]
                public string? OutProductId { get; set; }

                /// <summary>
                /// 获取或设置佣金率（单位：万分数）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commissionRatio")]
                [System.Text.Json.Serialization.JsonPropertyName("commissionRatio")]
                public int CommissionRatio { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("key")]
        [System.Text.Json.Serialization.JsonPropertyName("key")]
        public IList<Types.Product> ProductList { get; set; } = new List<Types.Product>();
    }
}
