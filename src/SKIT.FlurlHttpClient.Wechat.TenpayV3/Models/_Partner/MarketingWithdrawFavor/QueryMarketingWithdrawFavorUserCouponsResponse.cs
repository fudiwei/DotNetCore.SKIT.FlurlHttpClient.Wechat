using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/withdraw-favor/users/{openid}/coupons 接口的响应。</para>
    /// </summary>
    public class QueryMarketingWithdrawFavorUserCouponsResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Coupon
            {
                /// <summary>
                /// 获取或设置代金券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_id")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
                public string CouponId { get; set; } = default!;

                /// <summary>
                /// 获取或设置券状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_state")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_state")]
                public string? CouponState { get; set; }

                /// <summary>
                /// 获取或设置发放额度（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("send_quota")]
                [System.Text.Json.Serialization.JsonPropertyName("send_quota")]
                public int SendQuota { get; set; }

                /// <summary>
                /// 获取或设置使用额度（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("use_quota")]
                [System.Text.Json.Serialization.JsonPropertyName("use_quota")]
                public int UseQuota { get; set; }

                /// <summary>
                /// 获取或设置发券时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("send_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("send_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset SendTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Coupon[] CouponList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置券总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
