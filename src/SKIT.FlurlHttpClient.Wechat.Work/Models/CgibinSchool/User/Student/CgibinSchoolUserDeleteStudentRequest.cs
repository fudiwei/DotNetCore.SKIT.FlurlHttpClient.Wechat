namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/school/user/delete_student 接口的请求。</para>
    /// </summary>
    public class CgibinSchoolUserDeleteStudentRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置学生账号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string StudentUserId { get; set; } = string.Empty;
    }
}
