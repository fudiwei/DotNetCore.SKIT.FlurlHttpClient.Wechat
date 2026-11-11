namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    using SKIT.FlurlHttpClient.Internal.CodeAnalysis;

    /// <summary>
    /// <para>表示 [GET] /marketing/partner/product-coupon/users/{openid}/coupons/{coupon_code} 接口的响应。</para>
    /// </summary>
    public class GetMarketingPartnerProductCouponUserCouponByCouponCodeResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class BaseUsageDetail : QueryMarketingPartnerProductCouponUserCouponsResponse.Types.UserCoupon.Types.__zz__BaseUsageDetail
            {
                public static class Types
                {
                    public class AssociatedOrder : QueryMarketingPartnerProductCouponUserCouponsResponse.Types.UserCoupon.Types.BaseUsageDetail.Types.AssociatedOrder
                    {
                    }

                    public class AssociatedPayScoreOrder : QueryMarketingPartnerProductCouponUserCouponsResponse.Types.UserCoupon.Types.BaseUsageDetail.Types.AssociatedPayScoreOrder
                    {
                    }
                }

                /// <summary>
                /// 获取或设置关联订单信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("associated_order_info")]
                [System.Text.Json.Serialization.JsonPropertyName("associated_order_info")]
                public Types.AssociatedOrder? AssociatedOrder { get; set; }

                /// <summary>
                /// 获取或设置关联微信支付分订单信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("associated_pay_score_order_info")]
                [System.Text.Json.Serialization.JsonPropertyName("associated_pay_score_order_info")]
                public Types.AssociatedPayScoreOrder? AssociatedPayScoreOrder { get; set; }
            }

            public class SingleUsageDetail : BaseUsageDetail
            {
            }

            public class SequentialUsageDetail : QueryMarketingPartnerProductCouponUserCouponsResponse.Types.UserCoupon.Types.__zz__SequentialUsageDetail
            {
                public static class Types
                {
                    public class DetailItem : BaseUsageDetail
                    {
                        /// <summary>
                        /// 获取或设置轮次使用详情状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("detail_state")]
                        [System.Text.Json.Serialization.JsonPropertyName("detail_state")]
                        public string? DetailState { get; set; }

                        /// <summary>
                        /// 获取或设置有效期开始时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_begin_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_begin_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
                        public DateTimeOffset ValidBeginTime { get; set; }

                        /// <summary>
                        /// 获取或设置有效期结束时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_end_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_end_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
                        public DateTimeOffset ValidEndTime { get; set; }

                        /// <summary>
                        /// 获取或设置删除时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delete_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("delete_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
                        public DateTimeOffset? DeleteTime { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置轮次使用详情列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail_item_list")]
                [System.Text.Json.Serialization.JsonPropertyName("detail_item_list")]
                public List<Types.DetailItem>? DetailItemList { get; set; }
            }

            public class ProductCouponInfo : QueryMarketingPartnerProductCouponUserCouponsResponse.Types.UserCoupon.Types.__zz__ProductCouponInfo
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
            }

            [DisallowAnalyzerRule("type-declaration/no-external-contract-nested-types", Addition = "SKIT.FlurlHttpClient.Wechat.TenpayV3.Models." + nameof(QueryMarketingPartnerProductCouponStocksResponse) + "+" + nameof(QueryMarketingPartnerProductCouponStocksResponse.Types) + "+" + nameof(QueryMarketingPartnerProductCouponStocksResponse.Types.Stock))]
            public class StockInfo : QueryMarketingPartnerProductCouponStocksResponse.Types.Stock
            {
            }

            public class TagInfo : SendMarketingPartnerProductCouponUserCouponRequest.Types.__zz__TagInfo
            {
                public static class Types
                {
                    public class MemberTag : SendMarketingPartnerProductCouponUserCouponRequest.Types.TagInfo.Types.MemberTag
                    {
                    }
                }

                /// <summary>
                /// 获取或设置会员标签信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("member_tag_info")]
                [System.Text.Json.Serialization.JsonPropertyName("member_tag_info")]
                public Types.MemberTag? MemberTag { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string? BrandId { get; set; }

        /// <summary>
        /// 获取或设置券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_code")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_code")]
        public string? CouponCode { get; set; }

        /// <summary>
        /// 获取或设置券状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_state")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_state")]
        public string? CouponState { get; set; }

        /// <summary>
        /// 获取或设置有效期开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("valid_begin_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("valid_begin_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset ValidBeginTime { get; set; }

        /// <summary>
        /// 获取或设置有效期结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("valid_end_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("valid_end_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset ValidEndTime { get; set; }

        /// <summary>
        /// 获取或设置领券时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receive_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("receive_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset ReceiveTime { get; set; }

        /// <summary>
        /// 获取或设置发券请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("send_request_no")]
        public string? SendOutRequestNumber { get; set; }

        /// <summary>
        /// 获取或设置发券渠道。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_channel")]
        [System.Text.Json.Serialization.JsonPropertyName("send_channel")]
        public string? SendChannel { get; set; }

        /// <summary>
        /// 获取或设置确认请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("confirm_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("confirm_request_no")]
        public string? ConfirmOutRequestNumber { get; set; }

        /// <summary>
        /// 获取或设置确认发放时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("confirm_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("confirm_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset? ConfirmTime { get; set; }

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

        /// <summary>
        /// 获取或设置单券使用详情。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("single_usage_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("single_usage_detail")]
        public Types.SingleUsageDetail? SingleUsageDetail { get; set; }

        /// <summary>
        /// 获取或设置多次优惠使用详情。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sequential_usage_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("sequential_usage_detail")]
        public Types.SequentialUsageDetail? SequentialUsageDetail { get; set; }

        /// <summary>
        /// 获取或设置商品券信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_coupon")]
        [System.Text.Json.Serialization.JsonPropertyName("product_coupon")]
        public Types.ProductCouponInfo? ProductCouponInfo { get; set; }

        /// <summary>
        /// 获取或设置批次信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock")]
        [System.Text.Json.Serialization.JsonPropertyName("stock")]
        public Types.StockInfo? StockInfo { get; set; }

        /// <summary>
        /// 获取或设置附加信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置渠道自定义信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_custom_info")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_custom_info")]
        public string? ChannelCustomInfo { get; set; }

        /// <summary>
        /// 获取或设置标签信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_tag_info")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_tag_info")]
        public Types.TagInfo? TagInfo { get; set; }
    }
}
