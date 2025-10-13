using System;

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
                    public class NormalCoupon
                    {
                        /// <summary>
                        /// 获取或设置门槛金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("threshold")]
                        [System.Text.Json.Serialization.JsonPropertyName("threshold")]
                        public int Threshold { get; set; }

                        /// <summary>
                        /// 获取或设置固定减免金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_amount")]
                        public int DiscountAmount { get; set; }
                    }

                    public class DiscountCoupon
                    {
                        /// <summary>
                        /// 获取或设置门槛金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("threshold")]
                        [System.Text.Json.Serialization.JsonPropertyName("threshold")]
                        public int Threshold { get; set; }

                        /// <summary>
                        /// 获取或设置固定减免百分比（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("percent_off")]
                        [System.Text.Json.Serialization.JsonPropertyName("percent_off")]
                        public int PercentOff { get; set; }
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
            }

            public class SequentialUsageInfo
            {
                /// <summary>
                /// 获取或设置多次优惠规则类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置可使用次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int Count { get; set; }

                /// <summary>
                /// 获取或设置有效天数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("available_days")]
                [System.Text.Json.Serialization.JsonPropertyName("available_days")]
                public int? AvailableDays { get; set; }

                /// <summary>
                /// 获取或设置使用间隔天数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("interval_days")]
                [System.Text.Json.Serialization.JsonPropertyName("interval_days")]
                public int? IntervalDays { get; set; }
            }

            public class DisplayInfo
            {
                public static class Types
                {
                    public class ComboPackage
                    {
                        public static class Types
                        {
                            public class Choice
                            {
                                /// <summary>
                                /// 获取或设置单品名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置单品图片 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("image_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("image_url")]
                                public string? ImageUrl { get; set; }

                                /// <summary>
                                /// 获取或设置跳转小程序 AppId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("mini_program_appid")]
                                [System.Text.Json.Serialization.JsonPropertyName("mini_program_appid")]
                                public string? MiniProgramAppId { get; set; }

                                /// <summary>
                                /// 获取或设置跳转小程序页面路径。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("mini_program_path")]
                                [System.Text.Json.Serialization.JsonPropertyName("mini_program_path")]
                                public string? MiniProgramPagePath { get; set; }

                                /// <summary>
                                /// 获取或设置单品价格（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("price")]
                                [System.Text.Json.Serialization.JsonPropertyName("price")]
                                public int Price { get; set; }

                                /// <summary>
                                /// 获取或设置单品数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("count")]
                                [System.Text.Json.Serialization.JsonPropertyName("count")]
                                public int Count { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置套餐名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置可选单品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pick_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("pick_count")]
                        public int PickCount { get; set; }

                        /// <summary>
                        /// 获取或设置单品列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("choice_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("choice_list")]
                        public Types.Choice[] ChoiceList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置商品券名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_url")]
                [System.Text.Json.Serialization.JsonPropertyName("image_url")]
                public string ImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置背景图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("background_url")]
                [System.Text.Json.Serialization.JsonPropertyName("background_url")]
                public string BackgroundUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置详情图片 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail_image_url_list")]
                [System.Text.Json.Serialization.JsonPropertyName("detail_image_url_list")]
                public string[]? DetailImageUrlList { get; set; }

                /// <summary>
                /// 获取或设置商品原价。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("original_price")]
                [System.Text.Json.Serialization.JsonPropertyName("original_price")]
                public int? OriginalPrice { get; set; }

                /// <summary>
                /// 获取或设置套餐组合列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("combo_package_list")]
                [System.Text.Json.Serialization.JsonPropertyName("combo_package_list")]
                public Types.ComboPackage[]? ComboPackageList { get; set; }
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
}
