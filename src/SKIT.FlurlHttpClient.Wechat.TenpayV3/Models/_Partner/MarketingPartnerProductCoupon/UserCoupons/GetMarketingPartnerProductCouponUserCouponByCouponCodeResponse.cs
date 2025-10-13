using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/partner/product-coupon/users/{openid}/coupons/{coupon_code} 接口的响应。</para>
    /// </summary>
    public class GetMarketingPartnerProductCouponUserCouponByCouponCodeResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class SingleUsageDetail : QueryMarketingPartnerProductCouponUserCouponsResponse.Types.UserCoupon.Types.SingleUsageDetail
            {
            }

            public class SequentialUsageDetail : QueryMarketingPartnerProductCouponUserCouponsResponse.Types.UserCoupon.Types.SequentialUsageDetail
            {
            }

            public class ProductCouponInfo : QueryMarketingPartnerProductCouponUserCouponsResponse.Types.UserCoupon.Types.ProductCouponInfo
            {
            }

            public class StockInfo : QueryMarketingPartnerProductCouponUserCouponsResponse.Types.UserCoupon.Types.StockInfo
            {
            }

            public class TagInfo : QueryMarketingPartnerProductCouponUserCouponsResponse.Types.UserCoupon.Types.TagInfo
            {
            }
        }

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string BrandId { get; set; } = default!;

        /// <summary>
        /// 获取或设置券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_code")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_code")]
        public string CouponCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置券状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_state")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_state")]
        public string CouponState { get; set; } = default!;

        /// <summary>
        /// 获取或设置有效期开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("valid_begin_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("valid_begin_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset ValidBeginTime { get; set; }

        /// <summary>
        /// 获取或设置有效期结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("valid_end_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("valid_end_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset ValidEndTime { get; set; }

        /// <summary>
        /// 获取或设置领券时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receive_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("receive_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset ReceiveTime { get; set; }

        /// <summary>
        /// 获取或设置发券请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("send_request_no")]
        public string SendOutRequestNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置发券渠道。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_channel")]
        [System.Text.Json.Serialization.JsonPropertyName("send_channel")]
        public string SendChannel { get; set; } = default!;

        /// <summary>
        /// 获取或设置确认请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("confirm_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("confirm_request_no")]
        public string? ConfirmOutRequestNumber { get; set; }

        /// <summary>
        /// 获取或设置确认发放时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("confirm_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("confirm_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? ConfirmTime { get; set; }

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

        /// <summary>
        /// 获取或设置单券使用详情。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("single_usage_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("single_usage_detail")]
        public Types.SingleUsageDetail? SingleUsageDetail { get; set; }

        /// <summary>
        /// 获取或设置多次优惠使用详情。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sequential_usage_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("sequential_usage_detail")]
        public Types.SequentialUsageDetail? SequentialUsageDetail { get; set; }

        /// <summary>
        /// 获取或设置商品券信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_coupon")]
        [System.Text.Json.Serialization.JsonPropertyName("product_coupon")]
        public Types.ProductCouponInfo ProductCouponInfo { get; set; } = default!;

        /// <summary>
        /// 获取或设置批次信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock")]
        [System.Text.Json.Serialization.JsonPropertyName("stock")]
        public Types.StockInfo StockInfo { get; set; } = default!;

        /// <summary>
        /// 获取或设置附加信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置渠道自定义信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_custom_info")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_custom_info")]
        public string? ChannelCustomInfo { get; set; }

        /// <summary>
        /// 获取或设置标签信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_tag_info")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_tag_info")]
        public Types.TagInfo? TagInfo { get; set; }
    }
}
