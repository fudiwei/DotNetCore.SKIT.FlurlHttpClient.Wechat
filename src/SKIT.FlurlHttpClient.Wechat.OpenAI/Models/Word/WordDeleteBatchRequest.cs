using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/word/delete/batch 接口的请求。</para>
    /// </summary>
    public class WordDeleteBatchRequest : WechatOpenAIRequest
    {
        /// <summary>
        /// 获取或设置词条 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("id_list")]
        public IList<long> WordIdList { get; set; } = new List<long>();
    }
}
