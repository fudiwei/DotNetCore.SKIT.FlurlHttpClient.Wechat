namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/knowledge/add_group 接口的请求。</para>
    /// </summary>
    public class CgibinKfKnowledgeAddGroupRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置分组名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }
}
