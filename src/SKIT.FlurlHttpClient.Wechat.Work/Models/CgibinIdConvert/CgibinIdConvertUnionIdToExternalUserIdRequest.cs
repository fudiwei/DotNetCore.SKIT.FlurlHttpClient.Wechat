namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/idconvert/unionid_to_external_userid 接口的请求。</para>
    /// </summary>
    public class CgibinIdConvertUnionIdToExternalUserIdRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置用户的微信 UnionId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unionid")]
        [System.Text.Json.Serialization.JsonPropertyName("unionid")]
        public string? UnionId { get; set; }

        /// <summary>
        /// 获取或设置用户的微信 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置主体类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subject_type")]
        [System.Text.Json.Serialization.JsonPropertyName("subject_type")]
        public int SubjectType { get; set; }
    }
}
