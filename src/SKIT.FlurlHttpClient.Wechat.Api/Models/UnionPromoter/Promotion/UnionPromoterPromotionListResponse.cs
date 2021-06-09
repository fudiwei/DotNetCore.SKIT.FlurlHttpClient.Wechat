using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /union/promoter/promotion/list 接口的响应。</para>
    /// </summary>
    public class UnionPromoterPromotionListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Promotion
            {
                /// <summary>
                /// 获取或设置推广位 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promotionSourcePid")]
                [System.Text.Json.Serialization.JsonPropertyName("promotionSourcePid")]
                public string PromotionId { get; set; } = default!;

                /// <summary>
                /// 获取或设置推广位名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promotionSourceName")]
                [System.Text.Json.Serialization.JsonPropertyName("promotionSourceName")]
                public string SourceName { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置推广位列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotionSourceList")]
        [System.Text.Json.Serialization.JsonPropertyName("promotionSourceList")]

        public Types.Promotion[] PromotionList { get; set; } = default!;

        /// <summary>
        /// 获取或设置推广位总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int Total { get; set; }

        /// <summary>
        /// 获取或设置允许创建的推广位最大数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotionMaxCnt")]
        [System.Text.Json.Serialization.JsonPropertyName("promotionMaxCnt")]
        public int MaxPromotionCount { get; set; }
    }
}
