using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/giftcard/page/get 接口的响应。</para>
    /// </summary>
    public class CardGiftCardPageGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Page : CardGiftCardPageAddRequest.Types.Page
            {
            }
        }

        /// <summary>
        /// 获取或设置货架信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public Types.Page Page { get; set; } = default!;
    }
}
