namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/partner/delivery-plan/delivery-plans 接口的请求。</para>
    /// </summary>
    public class CreateMarketingPartnerDeliveryPlanRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string? OutRequestNumber { get; set; }

        /// <summary>
        /// 获取或设置投放计划名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_name")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_name")]
        public string? PlanName { get; set; }

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string BrandId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_coupon_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_coupon_id")]
        public string ProductCouponId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品券批次 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_id")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
        public string? StockId { get; set; }

        /// <summary>
        /// 获取或设置商品券批次组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_bundle_id")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_bundle_id")]
        public string? StockBundleId { get; set; }

        /// <summary>
        /// 获取或设置商品券使用模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("usage_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("usage_mode")]
        public string? UsageMode { get; set; }

        /// <summary>
        /// 获取或设置是否复用商品券和批次信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reuse_coupon_config")]
        [System.Text.Json.Serialization.JsonPropertyName("reuse_coupon_config")]
        public bool IsReuseCouponConfig { get; set; }

        /// <summary>
        /// 获取或设置总库存数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 获取或设置单用户限领数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_limit")]
        [System.Text.Json.Serialization.JsonPropertyName("user_limit")]
        public int? UserLimitCount { get; set; }

        /// <summary>
        /// 获取或设置单日限领数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("daily_limit")]
        [System.Text.Json.Serialization.JsonPropertyName("daily_limit")]
        public int? DailyLimitCount { get; set; }

        /// <summary>
        /// 获取或设置是否过期券不占用领取次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exclude_expired_coupon_from_limit")]
        [System.Text.Json.Serialization.JsonPropertyName("exclude_expired_coupon_from_limit")]
        public bool? IsExcludeExpiredCouponFromLimit { get; set; }

        /// <summary>
        /// 获取或设置开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_start_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_start_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset? StartTime { get; set; }

        /// <summary>
        /// 获取或设置结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_end_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_end_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset? EndTime { get; set; }

        /// <summary>
        /// 获取或设置营销自定义文案。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recommend_word")]
        [System.Text.Json.Serialization.JsonPropertyName("recommend_word")]
        public string? RecommentWording { get; set; }
    }
}
