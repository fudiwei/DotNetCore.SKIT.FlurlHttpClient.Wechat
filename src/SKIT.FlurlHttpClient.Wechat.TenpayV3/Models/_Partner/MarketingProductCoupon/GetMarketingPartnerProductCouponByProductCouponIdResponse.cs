namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/partner/product-coupon/product-coupons/{product_coupon_id} 接口的响应。</para>
    /// </summary>
    public class GetMarketingPartnerProductCouponByProductCouponIdResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class SingleUsageInfo
            {
                public static class Types
                {
                    public class NormalCoupon : CreateMarketingPartnerProductCouponRequest.Types.SingleUsageInfo.Types.NormalCoupon
                    {
                    }

                    public class DiscountCoupon : CreateMarketingPartnerProductCouponRequest.Types.SingleUsageInfo.Types.DiscountCoupon
                    {
                    }

                    public class ExchangeCoupon : CreateMarketingPartnerProductCouponRequest.Types.SingleUsageInfo.Types.ExchangeCoupon
                    {
                    }
                }

                /// <summary>
                /// 获取或设置满减券使用规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("normal_coupon")]
                [System.Text.Json.Serialization.JsonPropertyName("normal_coupon")]
                public Types.NormalCoupon? NormalCoupon { get; set; }

                /// <summary>
                /// 获取或设置折扣券使用规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("discount_coupon")]
                [System.Text.Json.Serialization.JsonPropertyName("discount_coupon")]
                public Types.DiscountCoupon? DiscountCoupon { get; set; }

                /// <summary>
                /// 获取或设置兑换券使用规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exchange_coupon")]
                [System.Text.Json.Serialization.JsonPropertyName("exchange_coupon")]
                public Types.ExchangeCoupon? ExchangeCoupon { get; set; }
            }

            public class SequentialUsageInfo : CreateMarketingPartnerProductCouponRequest.Types.SequentialUsageInfo
            {
            }

            public class ProgressiveBundleUsageInfo : CreateMarketingPartnerProductCouponRequest.Types.ProgressiveBundleUsageInfo
            {
            }

            public class DisplayInfo : CreateMarketingPartnerProductCouponRequest.Types.__zz__DisplayInfo
            {
                public static class Types
                {
                    public class ComboPackage : CreateMarketingPartnerProductCouponRequest.Types.DisplayInfo.Types.__zz__ComboPackage
                    {
                        public static class Types
                        {
                            public class Choice : CreateMarketingPartnerProductCouponRequest.Types.DisplayInfo.Types.ComboPackage.Types.Choice
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置单品列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("choice_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("choice_list")]
                        public List<Types.Choice>? ChoiceList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置套餐组合列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("combo_package_list")]
                [System.Text.Json.Serialization.JsonPropertyName("combo_package_list")]
                public List<Types.ComboPackage>? ComboPackageList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_coupon_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_coupon_id")]
        public string? ProductCouponId { get; set; }

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string? BrandId { get; set; }

        /// <summary>
        /// 获取或设置优惠范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scope")]
        [System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// 获取或设置商品券类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 获取或设置业务模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("business_mode")]
        public string? BusinessMode { get; set; }

        /// <summary>
        /// 获取或设置使用模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("usage_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("usage_mode")]
        public string? UsageMode { get; set; }

        /// <summary>
        /// 获取或设置单券模式信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("single_usage_info")]
        [System.Text.Json.Serialization.JsonPropertyName("single_usage_info")]
        public Types.SingleUsageInfo? SingleUsageInfo { get; set; }

        /// <summary>
        /// 获取或设置多次优惠模式信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sequential_usage_info")]
        [System.Text.Json.Serialization.JsonPropertyName("sequential_usage_info")]
        public Types.SequentialUsageInfo? SequentialUsageInfo { get; set; }

        /// <summary>
        /// 获取或设置多次优惠模式信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("progressive_bundle_usage_info")]
        [System.Text.Json.Serialization.JsonPropertyName("progressive_bundle_usage_info")]
        public Types.ProgressiveBundleUsageInfo? ProgressiveBundleUsageInfo { get; set; }

        /// <summary>
        /// 获取或设置展示信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("display_info")]
        [System.Text.Json.Serialization.JsonPropertyName("display_info")]
        public Types.DisplayInfo? DisplayInfo { get; set; }

        /// <summary>
        /// 获取或设置外部商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_product_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_product_no")]
        public string? OutProductNumber { get; set; }

        /// <summary>
        /// 获取或设置是否展示兑换价。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("show_as_exchange")]
        [System.Text.Json.Serialization.JsonPropertyName("show_as_exchange")]
        public bool? IsShowAsExchange { get; set; }

        /// <summary>
        /// 获取或设置可用商品编码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_product_no_list")]
        [System.Text.Json.Serialization.JsonPropertyName("available_product_no_list")]
        public List<string>? AvailableProductNumberList { get; set; }

        /// <summary>
        /// 获取或设置商品券状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// 获取或设置失效请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deactivate_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("deactivate_request_no")]
        public string? DeactivateOutRequestNumber { get; set; }

        /// <summary>
        /// 获取或设置失效时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deactivate_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("deactivate_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset? DeactivateTime { get; set; }

        /// <summary>
        /// 获取或设置失效原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deactivate_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("deactivate_reason")]
        public string? DeactivateReason { get; set; }
    }
}
