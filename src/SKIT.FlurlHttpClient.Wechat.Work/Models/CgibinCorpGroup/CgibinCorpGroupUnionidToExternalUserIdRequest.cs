namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/corpgroup/unionid_to_external_userid 接口的请求。</para>
    /// </summary>
    public class CgibinCorpGroupUnionidToExternalUserIdRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置用户 UnionId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unionid")]
        [System.Text.Json.Serialization.JsonPropertyName("unionid")]
        public string? UnionId { get; set; }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置需要换取的企业 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("corpid")]
        public string? CorpId { get; set; }

        /// <summary>
        /// 获取或设置大批量调用凭据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mass_call_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("mass_call_ticket")]
        public string? MassCallTicket { get; set; }
    }
}
