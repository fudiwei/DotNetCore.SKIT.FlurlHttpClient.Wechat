namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/coupon/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECCouponGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Coupon
            {
                public static class Types
                {
                    public class CouponDetail
                    {
                        public static class Types
                        {
                            public class Discount : ChannelsECCouponCreateRequest.Types.Discount
                            {
                                public static new class Types
                                {
                                    public class DiscountCondidtion : ChannelsECCouponCreateRequest.Types.Discount.Types.DiscountCondidtion
                                    {
                                        /// <summary>
                                        /// 获取或设置商品 ID 列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("product_ids")]
                                        [System.Text.Json.Serialization.JsonPropertyName("product_ids")]
                                        public new long[]? ProductIdList { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置优惠条件信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("discount_condition")]
                                [System.Text.Json.Serialization.JsonPropertyName("discount_condition")]
                                public new Types.DiscountCondidtion? DiscountCondidtion { get; set; }
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
                        /// 获取或设置优惠券名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置优惠信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_info")]
                        public Types.Discount Discount { get; set; } = default!;

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
                        public Types.Validity Validity { get; set; } = default!;
                    }

                    public class CouponStock
                    {
                        /// <summary>
                        /// 获取或设置剩余量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("issued_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("issued_num")]
                        public int IssuedCount { get; set; }

                        /// <summary>
                        /// 获取或设置领用量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receive_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("receive_num")]
                        public int ReceivedCount { get; set; }

                        /// <summary>
                        /// 获取或设置已用量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("used_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("used_num")]
                        public int UsedCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置优惠券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_id")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long CouponId { get; set; }

                /// <summary>
                /// 获取或设置优惠券类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置优惠券状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置优惠券详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_info")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_info")]
                public Types.CouponDetail CouponDetail { get; set; } = default!;

                /// <summary>
                /// 获取或设置优惠券库存信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_info")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_info")]
                public Types.CouponStock CouponStock { get; set; } = default!;

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置优惠券信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon")]
        public Types.Coupon Coupon { get; set; } = default!;
    }
}
