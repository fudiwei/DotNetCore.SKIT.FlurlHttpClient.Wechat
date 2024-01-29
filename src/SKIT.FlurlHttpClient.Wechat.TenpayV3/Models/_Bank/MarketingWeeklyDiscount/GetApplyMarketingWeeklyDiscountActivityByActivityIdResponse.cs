using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/weekly-discount/activities/{activity_id} 接口的响应。</para>
    /// </summary>
    public class GetApplyMarketingWeeklyDiscountActivityByActivityIdResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        public string ActivityId { get; set; } = default!;

        /// <summary>
        /// 获取或设置活动名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_name")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_name")]
        public string ActivityName { get; set; } = default!;

        /// <summary>
        /// 获取或设置活动投放场景。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_scene")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_scene")]
        public string ActivityScene { get; set; } = default!;

        /// <summary>
        /// 获取或设置活动投放区域编码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_area_code")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_area_code")]
        public string[] ActivityAreaCodeList { get; set; } = default!;

        /// <summary>
        /// 获取或设置活动状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_state")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_state")]
        public string ActivityState { get; set; } = default!;

        /// <summary>
        /// 获取或设置指定付款方式编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_limit_pay")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_limit_pay")]
        public string? LimitPayCode { get; set; }

        /// <summary>
        /// 获取或设置活动优惠门槛（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_transaction_minimum_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_transaction_minimum_amount")]
        public int TransactionMinimumAmount { get; set; }

        /// <summary>
        /// 获取或设置活动优惠金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_coupon_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_coupon_amount")]
        public int CouponAmount { get; set; }

        /// <summary>
        /// 获取或设置可使用周期列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_available_week")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_available_week")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int[] AvailableWeekList { get; set; } = default!;

        /// <summary>
        /// 获取或设置活动预算（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_max_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_max_amount")]
        public int MaxAmount { get; set; }

        /// <summary>
        /// 获取或设置活动单日预算（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_max_amount_per_day")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_max_amount_per_day")]
        public int? MaxAmountPerDay { get; set; }

        /// <summary>
        /// 获取或设置活动开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_available_begin_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("activity_available_begin_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset BeginTime { get; set; }

        /// <summary>
        /// 获取或设置活动结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_available_end_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("activity_available_end_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset EndTime { get; set; }

        /// <summary>
        /// 获取或设置 Logo 地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_logo")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_logo")]
        public string? LogoUrl { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_remark")]
        public string? Remark { get; set; }
    }
}
