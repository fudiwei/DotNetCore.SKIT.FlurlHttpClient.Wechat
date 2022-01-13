namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/user/check_member_auth 接口的响应。</para>
    /// </summary>
    public class CgibinUserCheckMemberAuthResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置成员是否已授权。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_member_auth")]
        [System.Text.Json.Serialization.JsonPropertyName("is_member_auth")]
        public bool IsMemberAuth { get; set; }
    }
}
