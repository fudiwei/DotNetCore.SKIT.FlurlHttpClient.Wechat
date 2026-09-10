using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 PRODUCT_COUPON_SP.SEND 通知的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4016435717 ]]> <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015780862 ]]>
    /// </para>
    /// </summary>
    public class MarketingPartnerProductCouponResource : WechatTenpayEvent.Types.IDecryptedResource
    {
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
        /// 获取或设置商品券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_coupon_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_coupon_id")]
        public string ProductCouponId { get; set; } = default!;

        /// <summary>
        /// 获取或设置批次 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_id")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
        public string StockId { get; set; } = default!;

        /// <summary>
        /// 获取或设置批次组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_bundle_id")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_bundle_id")]
        public string? StockBundleId { get; set; }

        /// <summary>
        /// 获取或设置用户券组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_coupon_bundle_id")]
        [System.Text.Json.Serialization.JsonPropertyName("user_coupon_bundle_id")]
        public string? UserCouponBundleId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户的 UnionId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unionid")]
        [System.Text.Json.Serialization.JsonPropertyName("unionid")]
        public string? UnionId { get; set; }

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
        /// 获取或设置领券手机国际区号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("country_code")]
        [System.Text.Json.Serialization.JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// 获取或设置领券手机号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_number")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

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
    }
}
