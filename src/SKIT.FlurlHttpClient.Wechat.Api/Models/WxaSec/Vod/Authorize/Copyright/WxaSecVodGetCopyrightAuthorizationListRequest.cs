namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/getcopyrightauthorizationlist 接口的请求。</para>
    /// </summary>
    public class WxaSecVodGetCopyrightAuthorizationListRequest : WechatApiRequest, IInferable<WxaSecVodGetCopyrightAuthorizationListRequest, WxaSecVodGetCopyrightAuthorizationListResponse>
    {
        /// <summary>
        /// 获取或设置授权的剧目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("drama_id")]
        [System.Text.Json.Serialization.JsonPropertyName("drama_id")]
        public long? DramaId { get; set; }

        /// <summary>
        /// 获取或设置授权类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorization_type")]
        [System.Text.Json.Serialization.JsonPropertyName("authorization_type")]
        public int? AuthorizationType { get; set; }

        /// <summary>
        /// 获取或设置被授权方小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorized_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("authorized_appid")]
        public string? AuthorizedAppId { get; set; }

        /// <summary>
        /// 获取或设置被授权方主体证件号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorized_subject_cert_no")]
        [System.Text.Json.Serialization.JsonPropertyName("authorized_subject_cert_no")]
        public string? AuthorizedSubjectCertificateNumber { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }
    }
}
