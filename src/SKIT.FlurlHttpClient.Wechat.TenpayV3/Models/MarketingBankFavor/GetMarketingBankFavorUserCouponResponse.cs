using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/bank-favor/users/{openid}/coupons/{coupon_id} 接口的响应。</para>
    /// </summary>
    public class GetMarketingBankFavorUserCouponResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class UsedAmountList
            {
                /// <summary>
                /// 获取或设置已用金额列表（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("used_amounts")]
                [System.Text.Json.Serialization.JsonPropertyName("used_amounts")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int[] Items { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置批次 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_id")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
        public string StockId { get; set; } = default!;

        /// <summary>
        /// 获取或设置创建批次的商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_creator_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_creator_mchid")]
        public string StockCreatorMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置代金券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_id")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
        public string CouponId { get; set; } = default!;

        /// <summary>
        /// 获取或设置代金券名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_name")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_name")]
        public string CouponName { get; set; } = default!;

        /// <summary>
        /// 获取或设置代金券状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_state")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_state")]
        public string CouponState { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置领券时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receive_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("receive_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset ReceiveTime { get; set; }

        /// <summary>
        /// 获取或设置券可使用开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_begin_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("available_begin_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset AvailableBeginTime { get; set; }

        /// <summary>
        /// 获取或设置券可使用结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_end_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("available_end_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset AvailableEndTime { get; set; }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置多笔立减活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        public string ActivityId { get; set; } = default!;

        /// <summary>
        /// 获取或设置券最大使用次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_use_number")]
        [System.Text.Json.Serialization.JsonPropertyName("max_use_number")]
        public int MaxUseCount { get; set; }

        /// <summary>
        /// 获取或设置券剩余可用次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_number")]
        [System.Text.Json.Serialization.JsonPropertyName("available_number")]
        public int AvailableCount { get; set; }

        /// <summary>
        /// 获取或设置券已使用次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("used_number")]
        [System.Text.Json.Serialization.JsonPropertyName("used_number")]
        public int UsedCount { get; set; }

        /// <summary>
        /// 获取或设置已用金额列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("use_amount_list")]
        [System.Text.Json.Serialization.JsonPropertyName("use_amount_list")]
        public Types.UsedAmountList? UsedAmountList { get; set; }
    }
}
