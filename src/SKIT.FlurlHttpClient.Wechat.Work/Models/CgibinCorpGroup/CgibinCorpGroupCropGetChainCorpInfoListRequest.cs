namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/corpgroup/corp/get_chain_corpinfo_list 接口的请求。</para>
    /// </summary>
    public class CgibinCorpGroupCropGetChainCorpInfoListRequest : WechatWorkRequest
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
        /// 获取或设置是否递归获取子分组企业。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fetch_child")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("fetch_child")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? RequireFetchChild { get; set; }
    }
}
