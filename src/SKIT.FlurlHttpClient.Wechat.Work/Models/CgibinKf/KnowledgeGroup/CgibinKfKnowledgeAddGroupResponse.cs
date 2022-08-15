namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/knowledge/add_group 接口的响应。</para>
    /// </summary>
    public class CgibinKfKnowledgeAddGroupResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置分组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string GroupId { get; set; } = default!;
    }
}
