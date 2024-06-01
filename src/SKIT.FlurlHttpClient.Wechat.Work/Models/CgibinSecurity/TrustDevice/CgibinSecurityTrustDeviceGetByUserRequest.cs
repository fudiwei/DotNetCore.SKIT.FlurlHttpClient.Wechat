namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/security/trustdevice/get_by_user 接口的请求。</para>
    /// </summary>
    public class CgibinSecurityTrustDeviceGetByUserRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置设备类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置最后登录成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_login_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("last_login_userid")]
        public string LastLoginUserId { get; set; } = string.Empty;
    }
}
