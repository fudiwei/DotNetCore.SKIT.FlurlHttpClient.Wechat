namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/corpgroup/corp/get_chain_corpinfo_list 接口的请求。</para>
    /// </summary>
    public class CgibinCorpGroupCorpGetChainCorpInfoListRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置上下游 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chain_id")]
        [System.Text.Json.Serialization.JsonPropertyName("chain_id")]
        public string ChainId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("groupid")]
        [System.Text.Json.Serialization.JsonPropertyName("groupid")]
        public int? GroupId { get; set; }

        /// <summary>
        /// 获取或设置是否需要返回未加入的企业。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_pending")]
        [System.Text.Json.Serialization.JsonPropertyName("need_pending")]
        public bool? RequirePending { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }
    }
}
