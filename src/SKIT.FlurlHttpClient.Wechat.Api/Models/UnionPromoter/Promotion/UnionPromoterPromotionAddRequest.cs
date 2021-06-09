using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /union/promoter/promotion/add 接口的请求。</para>
    /// </summary>
    public class UnionPromoterPromotionAddRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置推广位名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotionSourceName")]
        [System.Text.Json.Serialization.JsonPropertyName("promotionSourceName")]
        public string SourceName { get; set; } = string.Empty;
    }
}
