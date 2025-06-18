namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/exmail/publicmail/delete_auth_code 接口的请求。</para>
    /// </summary>
    public class CgibinExmailPublicMailDeleteAuthCodeRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置业务邮箱 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// 获取或设置客户端专用密码 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_code_id")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_code_id")]
        public int AuthCodeId { get; set; }
    }
}
