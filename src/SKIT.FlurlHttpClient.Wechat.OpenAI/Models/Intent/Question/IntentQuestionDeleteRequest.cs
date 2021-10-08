using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/intent/question/delete 接口的请求。</para>
    /// </summary>
    public class IntentQuestionDeleteRequest : WechatOpenAIRequest
    {
        /// <summary>
        /// 获取或设置意图问题 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("id_list")]
        public IList<long> IntentQuestionIdList { get; set; } = new List<long>();
    }
}
