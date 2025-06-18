namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/auth/getuserinfo 接口的请求。</para>
    /// </summary>
    public class CgibinAuthGetUserInfoRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置成员授权码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Code { get; set; } = string.Empty;
    }
}
