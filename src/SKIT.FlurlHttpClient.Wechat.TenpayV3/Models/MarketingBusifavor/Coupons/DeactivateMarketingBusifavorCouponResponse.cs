using System;
using System.Collections.Generic;

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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("wechatpay_deactivate_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset WechatpayDeactivateTime { get; set; }
    }
}
