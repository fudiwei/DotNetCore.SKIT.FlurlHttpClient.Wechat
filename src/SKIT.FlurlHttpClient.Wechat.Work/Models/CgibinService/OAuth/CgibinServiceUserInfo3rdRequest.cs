namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/service/getuserinfo3rd 接口的请求。</para>
    /// </summary>
    public class CgibinServiceUserInfo3rdRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置授权码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Code { get; set; } = string.Empty;
    }
}
