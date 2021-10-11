using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/intent/get_detail 接口的请求。</para>
    /// </summary>
    public class IntentGetDetailRequest : WechatOpenAIThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置意图 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public long IntentId { get; set; }
    }
}
