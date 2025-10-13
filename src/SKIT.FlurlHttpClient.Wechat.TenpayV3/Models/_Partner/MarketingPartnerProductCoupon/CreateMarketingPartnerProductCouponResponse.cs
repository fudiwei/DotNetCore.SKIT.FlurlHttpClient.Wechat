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
        }

        /// <summary>
        /// 获取或设置批次信息1。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock")]
        [System.Text.Json.Serialization.JsonPropertyName("stock")]
        public Types.StockInfo? StockInfo { get; set; }
    }
}
