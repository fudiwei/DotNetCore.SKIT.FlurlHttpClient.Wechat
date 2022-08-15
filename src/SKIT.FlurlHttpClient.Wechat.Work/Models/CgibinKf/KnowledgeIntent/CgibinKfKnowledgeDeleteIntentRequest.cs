namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/knowledge/del_intent 接口的请求。</para>
    /// </summary>
    public class CgibinKfKnowledgeDeleteIntentRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置问答 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("intent_id")]
        public string IntentId { get; set; } = string.Empty;
    }
}
