using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /union/promoter/promotion/del 接口的请求。</para>
    /// </summary>
    public class UnionPromoterPromotionDeleteRequest : WechatApiRequest, IMapResponse<UnionPromoterPromotionDeleteRequest, UnionPromoterPromotionDeleteResponse>
    {
        /// <summary>
        /// 获取或设置推广位 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotionSourcePid")]
        [System.Text.Json.Serialization.JsonPropertyName("promotionSourcePid")]
        public string PromotionId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置推广位名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotionSourceName")]
        [System.Text.Json.Serialization.JsonPropertyName("promotionSourceName")]
        public string SourceName { get; set; } = string.Empty;
    }
}
