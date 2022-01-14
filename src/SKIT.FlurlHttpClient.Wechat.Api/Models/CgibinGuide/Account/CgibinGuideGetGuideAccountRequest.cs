namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/guide/getguideacct 接口的请求。</para>
    /// </summary>
    public class CgibinGuideGetGuideAccountRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置顾问微信号。与字段 <see cref="GuideOpenId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? GuideAccount { get; set; }

        /// <summary>
        /// 获取或设置顾问 OpenId。与字段 <see cref="GuideAccount"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? GuideOpenId { get; set; }
    }
}
