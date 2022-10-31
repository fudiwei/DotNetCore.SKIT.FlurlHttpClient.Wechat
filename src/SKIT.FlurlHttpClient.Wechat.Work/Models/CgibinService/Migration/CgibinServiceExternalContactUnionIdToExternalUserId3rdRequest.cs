namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/externalcontact/unionid_to_external_userid_3rd 接口的请求。</para>
    /// </summary>
    public class CgibinServiceExternalContactUnionIdToExternalUserId3rdRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置微信 UnionId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unionid")]
        [System.Text.Json.Serialization.JsonPropertyName("unionid")]
        public string UnionId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置需要换取的企业 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("corpid")]
        public string? CorpId { get; set; }
    }
}
