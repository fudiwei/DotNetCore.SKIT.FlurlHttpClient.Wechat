using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/busifavor/coupons/use 接口的请求。</para>
    /// </summary>
    public class SetMarketingBusifavorCouponUsedRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置批次号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_id")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
        public string StockId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商家券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_code")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_code")]
        public string CouponCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置核销请求单据号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("use_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("use_request_no")]
        public string UseOutRequestNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置核销请求时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("use_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("use_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset UseTime { get; set; }
    }
}
