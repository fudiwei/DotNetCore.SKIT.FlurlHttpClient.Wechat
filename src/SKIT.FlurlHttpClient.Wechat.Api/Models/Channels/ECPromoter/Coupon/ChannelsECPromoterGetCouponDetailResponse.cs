namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_coupon_detail 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetCouponDetailResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Coupon : ChannelsECCouponGetResponse.Types.__zz__Coupon
            {
                public static class Types
                {
                    public class CouponInfo : ChannelsECCouponGetResponse.Types.Coupon.Types.__zz__CouponInfo
                    {
                        public static class Types
                        {
                            public class Discount : ChannelsECCouponCreateRequest.Types.__zz__Discount
                            {
                                public static class Types
                                {
                                    public class DiscountCondidtion : ChannelsECCouponCreateRequest.Types.Discount.Types.DiscountCondidtion
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置优惠条件信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("discount_condition")]
                                [System.Text.Json.Serialization.JsonPropertyName("discount_condition")]
                                public Types.DiscountCondidtion? DiscountCondidtion { get; set; }
                            }

                            public class Extra : ChannelsECCouponCreateRequest.Types.Extra
                            {
                            }

                            public class Promotion : ChannelsECCouponCreateRequest.Types.Promotion
                            {
                            }

                            public class Reception : ChannelsECCouponCreateRequest.Types.Reception
                            {
                            }

                            public class Validity : ChannelsECCouponCreateRequest.Types.Validity
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置优惠信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_info")]
                        public Types.Discount? Discount { get; set; }

                        /// <summary>
                        /// 获取或设置扩展信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ext_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("ext_info")]
                        public Types.Extra? Extra { get; set; }

                        /// <summary>
                        /// 获取或设置推广信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promote_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("promote_info")]
                        public Types.Promotion? Promotion { get; set; }

                        /// <summary>
                        /// 获取或设置接收信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receive_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("receive_info")]
                        public Types.Reception? Reception { get; set; }

                        /// <summary>
                        /// 获取或设置有效期信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_info")]
                        public Types.Validity? Validity { get; set; }
                    }

                    public class StockInfo : ChannelsECCouponGetResponse.Types.Coupon.Types.StockInfo
                    {
                    }
                }

                /// <summary>
                /// 获取或设置优惠券详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_info")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_info")]
                public Types.CouponInfo? CouponInfo { get; set; }

                /// <summary>
                /// 获取或设置优惠券库存信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_info")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_info")]
                public Types.StockInfo? StockInfo { get; set; }

                /// <summary>
                /// 获取或设置是否可膨胀。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_can_up")]
                [System.Text.Json.Serialization.JsonPropertyName("is_can_up")]
                public bool IsCanUp { get; set; }

                /// <summary>
                /// 获取或设置膨胀最大倍数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("can_up_times")]
                [System.Text.Json.Serialization.JsonPropertyName("can_up_times")]
                public int CanUpTimes { get; set; }

                /// <summary>
                /// 获取或设置最大优惠金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("discount_limit")]
                [System.Text.Json.Serialization.JsonPropertyName("discount_limit")]
                public int? DiscountLimit { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置券信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon")]
        public Types.Coupon? Coupon { get; set; }
    }
}
