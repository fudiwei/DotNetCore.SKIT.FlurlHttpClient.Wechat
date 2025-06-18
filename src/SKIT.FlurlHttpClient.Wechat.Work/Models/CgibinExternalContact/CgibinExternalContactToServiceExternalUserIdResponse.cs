namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/to_service_external_userid 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactToServiceExternalUserIdResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置第三方应用的外部联系人账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
        public string ExternalUserId { get; set; } = default!;
    }
}
