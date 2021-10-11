using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/slot/delete 接口的请求。</para>
    /// </summary>
    public class SlotDeleteRequest : WechatOpenAIThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置语义槽 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("id_list")]
        public IList<long> SlotIdList { get; set; } = new List<long>();

        /// <summary>
        /// 获取或设置意图 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("intent_id")]
        public long? IntentId { get; set; }

        /// <summary>
        /// 获取或设置是否删除语义槽。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auto_delete_slot")]
        [System.Text.Json.Serialization.JsonPropertyName("auto_delete_slot")]
        public bool? AutoDeleteSlot { get; set; }
    }
}
