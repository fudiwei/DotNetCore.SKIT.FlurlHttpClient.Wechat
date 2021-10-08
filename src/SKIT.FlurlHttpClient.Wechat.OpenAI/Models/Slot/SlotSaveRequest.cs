using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/slot/save 接口的请求。</para>
    /// </summary>
    public class SlotSaveRequest : WechatOpenAIRequest
    {
        public static class Types
        {
            public class Slot
            {
                /// <summary>
                /// 获取或设置语义槽 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public long? SlotId { get; set; }

                /// <summary>
                /// 获取或设置语义槽名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置词典名称列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dicts")]
                [System.Text.Json.Serialization.JsonPropertyName("dicts")]
                public IList<string> DictionaryNameList { get; set; } = new List<string>();

                /// <summary>
                /// 获取或设置追问话术列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ask_content")]
                [System.Text.Json.Serialization.JsonPropertyName("ask_content")]
                public IList<string> AskContentList { get; set; } = new List<string>();

                /// <summary>
                /// 获取或设置关联的意图 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("intent_id")]
                [System.Text.Json.Serialization.JsonPropertyName("intent_id")]
                public long? IntentId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置语义槽列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public IList<Types.Slot> SlotList { get; set; } = new List<Types.Slot>();
    }
}
