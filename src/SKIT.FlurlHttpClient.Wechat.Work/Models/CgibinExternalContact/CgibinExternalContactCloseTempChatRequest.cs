namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/close_temp_chat 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactCloseTempChatRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置外部联系人账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
        public string ExternalUserId { get; set; } = string.Empty;
    }
}
