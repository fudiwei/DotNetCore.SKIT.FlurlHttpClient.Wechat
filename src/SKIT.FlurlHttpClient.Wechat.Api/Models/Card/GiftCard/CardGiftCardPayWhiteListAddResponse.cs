using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/giftcard/pay/whitelist/add 接口的响应。</para>
    /// </summary>
    public class CardGiftCardPayWhiteListAddResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = default!;
    }
}
