namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /marketing/partner/product-coupon/product-coupons/{product_coupon_id} 接口的请求。</para>
    /// </summary>
    public class UpdateMarketingPartnerProductCouponRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class DisplayInfo : CreateMarketingPartnerProductCouponRequest.Types.DisplayInfo
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
        /// 获取或设置商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumebr { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置展示信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("display_info")]
        [System.Text.Json.Serialization.JsonPropertyName("display_info")]
        public Types.DisplayInfo DisplayInfo { get; set; } = new Types.DisplayInfo();
    }
}
