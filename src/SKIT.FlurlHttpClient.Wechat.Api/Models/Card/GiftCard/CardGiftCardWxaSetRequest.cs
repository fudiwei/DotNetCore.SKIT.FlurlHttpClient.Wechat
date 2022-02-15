using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/giftcard/wxa/set 接口的请求。</para>
    /// </summary>
    public class CardGiftCardWxaSetRequest : WechatApiRequest, IMapResponse<CardGiftCardWxaSetRequest, CardGiftCardWxaSetResponse>
    {
        /// <summary>
        /// 获取或设置微信小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wxa_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("wxa_appid")]
        public string MiniProgramAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置货架 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_id")]
        [System.Text.Json.Serialization.JsonPropertyName("page_id")]
        public string PageId { get; set; } = string.Empty;
    }
}
