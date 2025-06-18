namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/corpgroup/corp/get_chain_user_custom_id 接口的响应。</para>
    /// </summary>
    public class CgibinCorpGroupCorpGetChainUserCustomIdResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置上下游用户自定义 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_custom_id")]
        [System.Text.Json.Serialization.JsonPropertyName("user_custom_id")]
        public string UserCustomId { get; set; } = default!;
    }
}
