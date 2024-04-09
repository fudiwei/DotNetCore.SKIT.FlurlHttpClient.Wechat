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

        /// <summary>
        /// 获取或设置业务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_type")]
        [System.Text.Json.Serialization.JsonPropertyName("business_type")]
        public int? BusinessType { get; set; }

        /// <summary>
        /// 获取或设置下游企业 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("corpid")]
        public string? CorpId { get; set; }

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
