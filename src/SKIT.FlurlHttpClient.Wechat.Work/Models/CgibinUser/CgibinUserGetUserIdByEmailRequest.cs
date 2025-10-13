namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/user/get_userid_by_email 接口的请求。</para>
    /// </summary>
    public class CgibinUserGetUserIdByEmailRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置邮箱类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("email_type")]
        [System.Text.Json.Serialization.JsonPropertyName("email_type")]
        public int? EmailType { get; set; }

        /// <summary>
        /// 获取或设置邮箱。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("email")]
        [System.Text.Json.Serialization.JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;
    }
}
