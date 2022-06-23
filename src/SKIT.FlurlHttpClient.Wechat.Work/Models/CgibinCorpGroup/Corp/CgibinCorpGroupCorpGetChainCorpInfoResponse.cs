namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/corpgroup/corp/get_chain_corpinfo 接口的响应。</para>
    /// </summary>
    public class CgibinCorpGroupCorpGetChainCorpInfoResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置分组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("groupid")]
        [System.Text.Json.Serialization.JsonPropertyName("groupid")]
        public int GroupId { get; set; }

        /// <summary>
        /// 获取或设置自定义 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_id")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_id")]
        public string? CustomId { get; set; }
    }
}
