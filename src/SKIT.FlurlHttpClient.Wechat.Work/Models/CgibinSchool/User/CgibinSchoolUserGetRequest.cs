namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/school/user/get 接口的请求。</para>
    /// </summary>
    public class CgibinSchoolUserGetRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置学生或家长账号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string StudentOrParentUserId { get; set; } = string.Empty;
    }
}
