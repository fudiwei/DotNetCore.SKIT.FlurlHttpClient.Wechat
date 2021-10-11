using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v1/intent/switch/batch 接口的请求。</para>
    /// </summary>
    public class IntentSwitchBatchRequest : WechatOpenAIThirdPartyRequest
    {
        public static class Types
        {
            public class Intent
            {
                /// <summary>
                /// 获取或设置意图 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public long IntentId { get; set; }

                /// <summary>
                /// 获取或设置意图开关。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("switch")]
                [System.Text.Json.Serialization.JsonPropertyName("switch")]
                public bool Switch { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置意图列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("switch_list")]
        [System.Text.Json.Serialization.JsonPropertyName("switch_list")]
        public IList<Types.Intent> IntentList { get; set; } = new List<Types.Intent>();
    }
}
