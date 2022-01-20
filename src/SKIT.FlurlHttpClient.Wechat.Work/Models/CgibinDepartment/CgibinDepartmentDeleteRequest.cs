namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/department/delete 接口的请求。</para>
    /// </summary>
    public class CgibinDepartmentDeleteRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置部门 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int DepartmentId { get; set; }
    }
}
