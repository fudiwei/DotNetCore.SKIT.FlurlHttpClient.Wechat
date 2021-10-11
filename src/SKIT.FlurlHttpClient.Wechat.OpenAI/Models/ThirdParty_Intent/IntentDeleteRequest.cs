using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/intent/delete 接口的请求。</para>
    /// </summary>
    public class IntentDeleteRequest : WechatOpenAIThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置意图 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("id_list")]
        public IList<long> IntentIdList { get; set; } = new List<long>();
    }
}
