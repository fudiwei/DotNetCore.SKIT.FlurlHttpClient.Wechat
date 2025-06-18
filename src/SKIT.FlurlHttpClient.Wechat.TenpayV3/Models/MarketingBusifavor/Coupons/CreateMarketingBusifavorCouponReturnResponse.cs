using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/busifavor/coupons/return 接口的响应。</para>
    /// </summary>
    public class CreateMarketingBusifavorCouponReturnResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信侧退券时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wechatpay_return_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("wechatpay_return_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset WechatpayReturnTime { get; set; }
    }
}
