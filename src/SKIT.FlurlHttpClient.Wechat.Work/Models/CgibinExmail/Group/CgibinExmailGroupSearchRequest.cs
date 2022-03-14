namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/exmail/group/search 接口的请求。</para>
    /// </summary>
    public class CgibinExmailGroupSearchRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置是否开启模糊搜索。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public bool IsFuzzy { get; set; }

        /// <summary>
        /// 获取或设置邮件群组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? GroupId { get; set; }
    }
}
