namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/exmail/publicmail/get_auth_code_list 接口的请求。</para>
    /// </summary>
    public class CgibinExmailPublicMailGetAuthCodeListRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置业务邮箱 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
