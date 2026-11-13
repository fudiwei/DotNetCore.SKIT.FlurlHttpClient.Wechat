namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/aibot/topic/get_topic_list 接口的请求。</para>
    /// </summary>
    public class CgibinAIBotTopicGetTopicListRequest : WechatWorkAIBotRequest
    {
        /// <summary>
        /// 获取或设置获取类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        /// 获取或设置频道 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("topic_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("topic_id_list")]
        public List<string>? TopicIdList { get; set; }

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }
    }
}
