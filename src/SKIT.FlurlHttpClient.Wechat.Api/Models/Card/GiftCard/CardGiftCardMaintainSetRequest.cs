using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/giftcard/maintain/set 接口的请求。</para>
    /// </summary>
    public class CardGiftCardMaintainSetRequest : WechatApiRequest, IMapResponse<CardGiftCardMaintainSetRequest, CardGiftCardMaintainSetResponse>
    {
        /// <summary>
        /// 获取或设置货架 ID。与字段 <see cref="IsAllPage"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_id")]
        [System.Text.Json.Serialization.JsonPropertyName("page_id")]
        public string? PageId { get; set; }

        /// <summary>
        /// 获取或设置是否下架全部货架。与字段 <see cref="PageId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("all")]
        [System.Text.Json.Serialization.JsonPropertyName("all")]
        public bool? IsAllPage { get; set; }

        /// <summary>
        /// 获取或设置货架 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maintain")]
        [System.Text.Json.Serialization.JsonPropertyName("maintain")]
        public bool IsMaintained { get; set; }
    }
}
