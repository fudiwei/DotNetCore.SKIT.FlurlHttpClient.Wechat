using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/intent/save 接口的响应。</para>
    /// </summary>
    public class IntentSaveResponse : WechatOpenAIResponse<IntentSaveResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {

                public static class Types
                {
                    public class Intent
                    {
                        /// <summary>
                        /// 获取或设置意图 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("intent_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("intent_id")]
                        public long IntentId { get; set; }

                        /// <summary>
                        /// 获取或设置意图名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("intent_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("intent_name")]
                        public string Name { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置意图列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Intent[] IntentList { get; set; } = default!;

                /// <summary>
                /// 获取或设置意图数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int Count { get; set; }
            }
        }
    }
}
