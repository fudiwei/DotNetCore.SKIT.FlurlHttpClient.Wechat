namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/del_corp_tag 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactDeleteCorpTagRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置企业标签 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag_id")]
        [System.Text.Json.Serialization.JsonPropertyName("tag_id")]
        public List<string>? TagIdList { get; set; }

        /// <summary>
        /// 获取或设置企业标签分组 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public List<string>? TagGroupIdList { get; set; }

        /// <summary>
        /// 获取或设置授权方安装的应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? AgentId { get; set; }
    }
}
