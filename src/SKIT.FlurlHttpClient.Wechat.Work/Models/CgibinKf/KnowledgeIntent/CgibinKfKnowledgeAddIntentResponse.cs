namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/knowledge/add_intent 接口的响应。</para>
    /// </summary>
    public class CgibinKfKnowledgeAddIntentResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置问答 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("intent_id")]
        public string IntentId { get; set; } = default!;
    }
}
