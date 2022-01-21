using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/busifavor/coupons/disassociate 接口的响应。</para>
    /// </summary>
    public class DisassociateMarketingBusifavorCouponResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信侧取消关联成功时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wechatpay_disassociate_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("wechatpay_disassociate_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset WechatpayDisassociateTime { get; set; }
    }
}
