namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/to_service_external_userid 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactToServiceExternalUserIdRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置代开发自建应用的外部联系人账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
        public string ExternalUserId { get; set; } = string.Empty;
    }
}
