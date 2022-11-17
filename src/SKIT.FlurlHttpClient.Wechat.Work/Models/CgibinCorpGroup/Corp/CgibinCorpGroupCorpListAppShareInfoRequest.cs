namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/corpgroup/corp/list_app_share_info 接口的请求。</para>
    /// </summary>
    public class CgibinCorpGroupCorpListAppShareInfoRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置上级企业应用 ID。如果不指定将使用构造 <see cref="WechatWorkClient"/> 时的 <see cref="WechatWorkClientOptions.AgentId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? ParentAgentId { get; set; }
    }
}
