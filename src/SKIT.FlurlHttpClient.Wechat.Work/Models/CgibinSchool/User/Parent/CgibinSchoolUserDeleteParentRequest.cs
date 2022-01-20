namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/school/user/delete_parent 接口的请求。</para>
    /// </summary>
    public class CgibinSchoolUserDeleteParentRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置家长账号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ParentUserId { get; set; } = string.Empty;
    }
}
