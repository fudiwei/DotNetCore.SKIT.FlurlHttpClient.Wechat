using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /discount-card/cards 接口的响应。</para>
    /// </summary>
    public class PrepareDiscountCardResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置预领卡请求 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prepare_card_token")]
        [System.Text.Json.Serialization.JsonPropertyName("prepare_card_token")]
        public string PrepareCardToken { get; set; } = default!;
    }
}
