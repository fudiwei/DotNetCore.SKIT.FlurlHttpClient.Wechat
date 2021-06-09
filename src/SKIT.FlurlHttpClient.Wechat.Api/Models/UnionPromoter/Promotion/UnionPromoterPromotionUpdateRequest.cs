using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /union/promoter/promotion/upd 接口的请求。</para>
    /// </summary>
    public class UnionPromoterPromotionUpdateRequest : WechatApiRequest
    {
        public static class Types
        {
            public class Promotion
            {
                /// <summary>
                /// 获取或设置推广位名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promotionSourceName")]
                [System.Text.Json.Serialization.JsonPropertyName("promotionSourceName")]
                public string SourceName { get; set; } = string.Empty;
            }

            public class PreviousPromotion : Promotion
            {
                /// <summary>
                /// 获取或设置推广位 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promotionSourcePid")]
                [System.Text.Json.Serialization.JsonPropertyName("promotionSourcePid")]
                public string PromotionId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置修改前的推广位信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("previousPromotionInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("previousPromotionInfo")]
        public Types.PreviousPromotion PreviousPromotion { get; set; } = new Types.PreviousPromotion();

        /// <summary>
        /// 获取或设置修改后的推广位信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotionInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("promotionInfo")]
        public Types.Promotion Promotion { get; set; } = new Types.Promotion();
    }
}
