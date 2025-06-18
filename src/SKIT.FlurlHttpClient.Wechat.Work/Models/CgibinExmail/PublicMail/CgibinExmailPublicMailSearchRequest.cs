namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/exmail/publicmail/search 接口的请求。</para>
    /// </summary>
    public class CgibinExmailPublicMailSearchRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置是否开启模糊搜索。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public bool IsFuzzy { get; set; }

        /// <summary>
        /// 获取或设置业务邮箱或名称。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? EmailOrName { get; set; }
    }
}
