namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/corpgroup/corp/get_chain_user_custom_id 接口的请求。</para>
    /// </summary>
    public class CgibinCorpGroupCorpGetChainUserCustomIdRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置上下游 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chain_id")]
        [System.Text.Json.Serialization.JsonPropertyName("chain_id")]
        public string ChainId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置下级企业 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("corpid")]
        public string CorpId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置下级企业成员 UserId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;
    }
}
