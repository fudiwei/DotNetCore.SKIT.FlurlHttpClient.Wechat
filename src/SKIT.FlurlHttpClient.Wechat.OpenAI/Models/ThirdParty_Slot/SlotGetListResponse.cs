using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/slot/get_list 接口的响应。</para>
    /// </summary>
    public class SlotGetListResponse : WechatOpenAIThirdPartyResponse<SlotGetListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
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
                        public long SlotId { get; set; }

                        /// <summary>
                        /// 获取或设置语义槽名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置语义槽类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int SlotType { get; set; }

                        /// <summary>
                        /// 获取或设置词典名称列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("dicts")]
                        [System.Text.Json.Serialization.JsonPropertyName("dicts")]
                        public string[] DictionaryNameList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置追问话术列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ask_content")]
                        [System.Text.Json.Serialization.JsonPropertyName("ask_content")]
                        public string[] AskContentList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置语义槽列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Slot[] SlotList { get; set; } = default!;

                /// <summary>
                /// 获取或设置语义槽总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int TotalCount { get; set; }
            }
        }
    }
}
