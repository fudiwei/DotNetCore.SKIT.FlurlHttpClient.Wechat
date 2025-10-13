namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/partner/product-coupon/product-coupons/{product_coupon_id}/stocks/{stock_id}/update-budget 接口的请求。</para>
    /// </summary>
    public class UpdateMarketingPartnerProductCouponStockBudgetRequest : WechatTenpayRequest
    {
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
        /// 获取或设置批次 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string StockId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumebr { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置更新模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("update_mode")]
        public string UpdateMode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置当前批次发放次数总上限。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("current_max_count")]
        [System.Text.Json.Serialization.JsonPropertyName("current_max_count")]
        public int? CurrentMaxCount { get; set; }

        /// <summary>
        /// 获取或设置目标批次发放次数总上限。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target_max_count")]
        [System.Text.Json.Serialization.JsonPropertyName("target_max_count")]
        public int? TargetMaxCount { get; set; }

        /// <summary>
        /// 获取或设置当前批次每日发放次数上限。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("current_max_count_per_day")]
        [System.Text.Json.Serialization.JsonPropertyName("current_max_count_per_day")]
        public int? CurrentMaxCountPerDay { get; set; }

        /// <summary>
        /// 获取或设置目标批次每日发放次数上限。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target_max_count_per_day")]
        [System.Text.Json.Serialization.JsonPropertyName("target_max_count_per_day")]
        public int? TargetMaxCountPerDay { get; set; }
    }
}
