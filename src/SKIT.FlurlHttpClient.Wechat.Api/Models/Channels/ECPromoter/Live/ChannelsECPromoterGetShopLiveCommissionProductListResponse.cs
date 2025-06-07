namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_shop_live_commission_product_list 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetShopLiveCommissionProductListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product : ChannelsECPromoterGetLiveCommissionProductListResponse.Types.Product
            {
                /// <summary>
                /// 获取或设置佣金率（单位：万分数）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commission_rate")]
                [System.Text.Json.Serialization.JsonPropertyName("commission_rate")]
                public int CommissionRate { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_list")]
        [System.Text.Json.Serialization.JsonPropertyName("product_list")]
        public Types.Product[] ProductList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }
    }
}
