namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/exmail/publicmail/create 接口的响应。</para>
    /// </summary>
    public class CgibinExmailPublicMailCreateResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置业务邮箱 ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
