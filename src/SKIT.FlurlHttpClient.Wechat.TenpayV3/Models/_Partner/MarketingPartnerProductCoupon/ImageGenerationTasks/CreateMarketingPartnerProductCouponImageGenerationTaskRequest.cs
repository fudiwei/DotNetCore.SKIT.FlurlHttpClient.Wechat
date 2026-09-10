namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/partner/product-coupon/image-generation-tasks 接口的请求。</para>
    /// </summary>
    public class CreateMarketingPartnerProductCouponImageGenerationTaskRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class CombineImage
            {
                public static class Types
                {
                    public class NormalCoupon : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.UsageRule.Types.NormalCoupon
                    {
                    }

                    public class DiscountCoupon : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.UsageRule.Types.DiscountCoupon
                    {
                    }

                    public class ExchangeCoupon : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.UsageRule.Types.ExchangeCoupon
                    {
                    }
                }

                /// <summary>
                /// 获取或设置优惠范围。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scope")]
                [System.Text.Json.Serialization.JsonPropertyName("scope")]
                public string Scope { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商品券类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置使用模式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("usage_mode")]
                [System.Text.Json.Serialization.JsonPropertyName("usage_mode")]
                public string UsageMode { get; set; } = string.Empty;

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

                /// <summary>
                /// 获取或设置背景颜色（格式：#RRGGBB）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("background_color")]
                [System.Text.Json.Serialization.JsonPropertyName("background_color")]
                public string? BackgroundColor { get; set; }
            }

            public class CutOut
            {
                /// <summary>
                /// 获取或设置图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_url")]
                [System.Text.Json.Serialization.JsonPropertyName("image_url")]
                public string ImageUrl { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string BrandId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置图片生成任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string TaskId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置图片生成类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_generation_type")]
        [System.Text.Json.Serialization.JsonPropertyName("image_generation_type")]
        public string ImageGenerationType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置拼图数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_image")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_image")]
        public Types.CombineImage? CombineImage { get; set; }

        /// <summary>
        /// 获取或设置抠图数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cut_out")]
        [System.Text.Json.Serialization.JsonPropertyName("cut_out")]
        public Types.CutOut? CutOut { get; set; }
    }
}
