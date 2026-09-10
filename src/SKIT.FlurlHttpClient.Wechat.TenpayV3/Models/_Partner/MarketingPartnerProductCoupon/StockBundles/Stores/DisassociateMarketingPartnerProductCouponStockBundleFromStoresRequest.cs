using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/partner/product-coupon/product-coupons/{product_coupon_id}/stock-bundles/{stock_bundle_id}/disassociate-stores 接口的请求。</para>
    /// </summary>
    public class DisassociateMarketingPartnerProductCouponStockBundleFromStoresRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Store : AssociateMarketingPartnerProductCouponStockBundleToStoresRequest.Types.Store
            {
            }
        }

        /// <summary>
        /// 获取或设置商品券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProductCouponId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string BrandId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置批次组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string StockBundleId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_list")]
        [System.Text.Json.Serialization.JsonPropertyName("store_list")]
        public IList<Types.Store> StoreList { get; set; } = new List<Types.Store>();
    }
}
