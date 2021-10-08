using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/skill/delete 接口的请求。</para>
    /// </summary>
    public class SkillDeleteRequest : WechatOpenAIRequest
    {
        /// <summary>
        /// 获取或设置技能 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public IList<long> SkillIdList { get; set; } = new List<long>();
    }
}
