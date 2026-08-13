using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /brand/card/card-configs/preview-url 接口的响应。</para>
    /// </summary>
    public class GetBrandCardConfigPreviewUrlResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置业务申请编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_code")]
        [System.Text.Json.Serialization.JsonPropertyName("business_code")]
        public string BusinessCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applyment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("applyment_id")]
        public string ApplymentId { get; set; } = default!;

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string BrandId { get; set; } = default!;

        /// <summary>
        /// 获取或设置预览二维码 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_preview_url")]
        [System.Text.Json.Serialization.JsonPropertyName("card_preview_url")]
        public string PreviewUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置预览二维码 URL 过期时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_expired_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("url_expired_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset PreviewUrlExpiredTime { get; set; }
    }
}
