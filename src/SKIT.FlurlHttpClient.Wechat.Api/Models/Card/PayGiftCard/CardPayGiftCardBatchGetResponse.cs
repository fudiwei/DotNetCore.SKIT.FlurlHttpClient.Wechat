using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/paygiftcard/batchget 接口的响应。</para>
    /// </summary>
    public class CardPayGiftCardBatchGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Rule : CardPayGiftCardGetByIdResponse.Types.Rule
            {
            }
        }

        /// <summary>
        /// 获取或设置营销规则列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_list")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_list")]
        public Types.Rule[] RuleList { get; set; } = default!;

        /// <summary>
        /// 获取或设置营销规则总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int Total { get; set; }
    }
}
