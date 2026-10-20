using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/busifavor/coupons/deactivate 接口的响应。</para>
    /// </summary>
    public class DeactivateMarketingBusifavorCouponResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信侧券失效时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wechatpay_deactivate_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("wechatpay_deactivate_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset WechatpayDeactivateTime { get; set; }
    }
}
