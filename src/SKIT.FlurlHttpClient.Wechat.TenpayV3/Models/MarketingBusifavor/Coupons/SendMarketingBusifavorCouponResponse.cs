using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/busifavor/coupons/{card_id}/send 接口的响应。</para>
    /// </summary>
    public class SendMarketingBusifavorCouponResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置消费卡 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_code")]
        [System.Text.Json.Serialization.JsonPropertyName("card_code")]
        public string CardCode { get; set; } = default!;
    }
}
