namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/exmail/group/get 接口的请求。</para>
    /// </summary>
    public class CgibinExmailGroupGetRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置邮件群组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string GroupId { get; set; } = string.Empty;
    }
}
