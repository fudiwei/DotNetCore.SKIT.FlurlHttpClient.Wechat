using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/partner/product-coupon/product-coupons/{product_coupon_id}/stocks/{stock_id} 接口的响应。</para>
    /// </summary>
    public class GetMarketingPartnerProductCouponStockByStockIdResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class SendRule : QueryMarketingPartnerProductCouponStocksResponse.Types.Stock.Types.SendRule
            {
            }

            public class SingleUsageRule : QueryMarketingPartnerProductCouponStocksResponse.Types.Stock.Types.SingleUsageRule
            {
            }

            public class SequentialUsageRule : QueryMarketingPartnerProductCouponStocksResponse.Types.Stock.Types.SequentialUsageRule
            {
            }

            public class UsageRuleDisplayInfo : QueryMarketingPartnerProductCouponStocksResponse.Types.Stock.Types.UsageRuleDisplayInfo
            {
            }

            public class CouponDisplayInfo : QueryMarketingPartnerProductCouponStocksResponse.Types.Stock.Types.CouponDisplayInfo
            {
            }

            public class NotifyConfig : QueryMarketingPartnerProductCouponStocksResponse.Types.Stock.Types.NotifyConfig
            {
            }

            public class CodeCountInfo : QueryMarketingPartnerProductCouponStocksResponse.Types.Stock.Types.CodeCountInfo
            {
            }

            public class SentCountInfo : QueryMarketingPartnerProductCouponStocksResponse.Types.Stock.Types.SentCountInfo
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
        /// 获取或设置批次 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_id")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
        public string StockId { get; set; } = default!;

        /// <summary>
        /// 获取或设置券 Code 分配模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_code_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_code_mode")]
        public string CouponCodeMode { get; set; } = default!;

        /// <summary>
        /// 获取或设置发放规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_send_rule")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_send_rule")]
        public Types.SendRule SendRule { get; set; } = default!;

        /// <summary>
        /// 获取或设置单券使用规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("single_usage_rule")]
        [System.Text.Json.Serialization.JsonPropertyName("single_usage_rule")]
        public Types.SingleUsageRule? SingleUsageRule { get; set; }

        /// <summary>
        /// 获取或设置多次优惠使用规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sequential_usage_rule")]
        [System.Text.Json.Serialization.JsonPropertyName("sequential_usage_rule")]
        public Types.SequentialUsageRule? SequentialUsageRule { get; set; }

        /// <summary>
        /// 获取或设置使用规则展示信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("usage_rule_display_info")]
        [System.Text.Json.Serialization.JsonPropertyName("usage_rule_display_info")]
        public Types.UsageRuleDisplayInfo UsageRuleDisplayInfo { get; set; } = default!;

        /// <summary>
        /// 获取或设置商品券展示信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_display_info")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_display_info")]
        public Types.CouponDisplayInfo CouponDisplayInfo { get; set; } = default!;

        /// <summary>
        /// 获取或设置可用门店范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_scope")]
        [System.Text.Json.Serialization.JsonPropertyName("store_scope")]
        public string StoreScope { get; set; } = default!;

        /// <summary>
        /// 获取或设置事件通知配置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_config")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_config")]
        public Types.NotifyConfig? NotifyConfig { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置 Code 数量信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_code_count_info")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_code_count_info")]
        public Types.CodeCountInfo CodeCountInfo { get; set; } = default!;

        /// <summary>
        /// 获取或设置已发放数量信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sent_count_info")]
        [System.Text.Json.Serialization.JsonPropertyName("sent_count_info")]
        public Types.SentCountInfo SentCountInfo { get; set; } = default!;

        /// <summary>
        /// 获取或设置批次状态。
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
