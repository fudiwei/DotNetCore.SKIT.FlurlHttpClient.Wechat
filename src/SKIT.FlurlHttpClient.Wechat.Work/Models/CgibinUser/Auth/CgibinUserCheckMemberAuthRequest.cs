namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/user/check_member_auth 接口的请求。</para>
    /// </summary>
    public class CgibinUserCheckMemberAuthRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置第三方成员唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenUserId { get; set; } = string.Empty;
    }
}
