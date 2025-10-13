using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/partner/product-coupon/users/{openid}/coupons 接口的响应。</para>
    /// </summary>
    public class QueryMarketingPartnerProductCouponUserCouponsResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class UserCoupon
            {
                public static class Types
                {
                    public class UsageDetail
                    {
                        public static class Types
                        {
                            public class AssociatedOrder : UseMarketingPartnerProductCouponUserCouponRequest.Types.AssociatedOrder
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置核销请求单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("use_request_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("use_request_no")]
                        public string? UseOutRequestNumber { get; set; }

                        /// <summary>
                        /// 获取或设置核销时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("use_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("use_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                        public DateTimeOffset? UseTime { get; set; }

                        /// <summary>
                        /// 获取或设置退券请求单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("return_request_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("return_request_no")]
                        public string? ReturnOutRequestNumber { get; set; }

                        /// <summary>
                        /// 获取或设置退券时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("return_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("return_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                        public DateTimeOffset? ReturnTime { get; set; }

                        /// <summary>
                        /// 获取或设置关联订单信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("associated_order_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("associated_order_info")]
                        public Types.AssociatedOrder? AssociatedOrder { get; set; }
                    }

                    public class SingleUsageDetail : UsageDetail
                    {
                    }

                    public class SequentialUsageDetail
                    {
                        public static class Types
                        {
                            public class DetailItem : UsageDetail
                            {
                                /// <summary>
                                /// 获取或设置轮次使用详情状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("detail_state")]
                                [System.Text.Json.Serialization.JsonPropertyName("detail_state")]
                                public string DetailState { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置有效期开始时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("valid_begin_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("valid_begin_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                                public DateTimeOffset ValidBeginTime { get; set; }

                                /// <summary>
                                /// 获取或设置有效期结束时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("valid_end_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("valid_end_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                                public DateTimeOffset ValidEndTime { get; set; }

                                /// <summary>
                                /// 获取或设置删除时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("delete_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("delete_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                                public DateTimeOffset? DeleteTime { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置总可使用次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                        public int TotalCount { get; set; }

                        /// <summary>
                        /// 获取或设置已使用次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("used_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("used_count")]
                        public int UsedCount { get; set; }

                        /// <summary>
                        /// 获取或设置轮次使用详情列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("detail_item_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("detail_item_list")]
                        public Types.DetailItem[]? DetailItemList { get; set; }
                    }

                    public class ProductCouponInfo
                    {
                        public static class Types
                        {
                            public class SingleUsageInfo : GetMarketingPartnerProductCouponByProductCouponIdResponse.Types.SingleUsageInfo
                            {
                            }

                            public class SequentialUsageInfo : GetMarketingPartnerProductCouponByProductCouponIdResponse.Types.SequentialUsageInfo
                            {
                            }

                            public class DisplayInfo : GetMarketingPartnerProductCouponByProductCouponIdResponse.Types.DisplayInfo
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品券 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_coupon_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_coupon_id")]
                        public string ProductCouponId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置品牌 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brand_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
                        public string BrandId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置优惠范围。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scope")]
                        [System.Text.Json.Serialization.JsonPropertyName("scope")]
                        public string Scope { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品券类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置使用模式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("usage_mode")]
                        [System.Text.Json.Serialization.JsonPropertyName("usage_mode")]
                        public string UsageMode { get; set; } = default!;

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
                        /// 获取或设置展示信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("display_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("display_info")]
                        public Types.DisplayInfo DisplayInfo { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置外部商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_product_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_product_no")]
                        public string? OutProductNumber { get; set; }

                        /// <summary>
                        /// 获取或设置商品券状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("state")]
                        [System.Text.Json.Serialization.JsonPropertyName("state")]
                        public string State { get; set; } = default!;

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
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("deactivate_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                        public DateTimeOffset? DeactivateTime { get; set; }

                        /// <summary>
                        /// 获取或设置失效原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("deactivate_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("deactivate_reason")]
                        public string? DeactivateReason { get; set; }
                    }

                    public class StockInfo : QueryMarketingPartnerProductCouponStocksResponse.Types.Stock
                    {
                    }

                    public class TagInfo
                    {
                        public static class Types
                        {
                            public class MemberTag
                            {
                                /// <summary>
                                /// 获取或设置会员卡模板 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("member_card_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("member_card_id")]
                                public string MemberCardId { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置用户商品券标签列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_tag_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_tag_list")]
                        public string[]? CouponTagList { get; set; }

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
                public string BrandId { get; set; } = default!;

                /// <summary>
                /// 获取或设置券 Code。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_code")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_code")]
                public string CouponCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置券状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_state")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_state")]
                public string CouponState { get; set; } = default!;

                /// <summary>
                /// 获取或设置有效期开始时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("valid_begin_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("valid_begin_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset ValidBeginTime { get; set; }

                /// <summary>
                /// 获取或设置有效期结束时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("valid_end_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("valid_end_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset ValidEndTime { get; set; }

                /// <summary>
                /// 获取或设置领券时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receive_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("receive_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset ReceiveTime { get; set; }

                /// <summary>
                /// 获取或设置发券请求单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("send_request_no")]
                [System.Text.Json.Serialization.JsonPropertyName("send_request_no")]
                public string SendOutRequestNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置发券渠道。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("send_channel")]
                [System.Text.Json.Serialization.JsonPropertyName("send_channel")]
                public string SendChannel { get; set; } = default!;

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
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("confirm_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
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
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("deactivate_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
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
                public Types.ProductCouponInfo ProductCouponInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置批次信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock")]
                [System.Text.Json.Serialization.JsonPropertyName("stock")]
                public Types.StockInfo StockInfo { get; set; } = default!;

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

        /// <summary>
        /// 获取或设置用户券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_coupon_list")]
        [System.Text.Json.Serialization.JsonPropertyName("user_coupon_list")]
        public Types.UserCoupon[] UserCouponList { get; set; } = default!;

        /// <summary>
        /// 获取或设置下一页分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_page_token")]
        [System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// 获取或设置券总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
