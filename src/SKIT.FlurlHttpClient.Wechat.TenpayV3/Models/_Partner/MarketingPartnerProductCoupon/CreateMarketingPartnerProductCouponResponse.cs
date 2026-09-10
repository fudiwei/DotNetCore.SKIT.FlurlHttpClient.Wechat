namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/partner/product-coupon/product-coupons 接口的响应。</para>
    /// </summary>
    public class CreateMarketingPartnerProductCouponResponse : GetMarketingPartnerProductCouponByProductCouponIdResponse
    {
        public static new class Types
        {
            public class StockInfo : QueryMarketingPartnerProductCouponStocksResponse.Types.Stock
            {
            }

            public class StockBundle
            {
                public static class Types
                {
                    public class Stock : QueryMarketingPartnerProductCouponStocksResponse.Types.Stock
                    {
                    }
                }

                /// <summary>
                /// 获取或设置批次组 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_bundle_id")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_bundle_id")]
                public string ProductCouponId { get; set; } = default!;

                /// <summary>
                /// 获取或设置批次列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_list")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_list")]
                public Types.Stock[] StockList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置批次信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock")]
        [System.Text.Json.Serialization.JsonPropertyName("stock")]
        public Types.StockInfo? StockInfo { get; set; }

        /// <summary>
        /// 获取或设置批次组信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_bundle")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_bundle")]
        public Types.StockBundle? StockBundle { get; set; }
    }
}
