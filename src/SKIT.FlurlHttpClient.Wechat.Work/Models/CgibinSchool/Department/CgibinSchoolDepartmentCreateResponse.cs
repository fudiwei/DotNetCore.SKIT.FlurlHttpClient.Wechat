namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/department/create 接口的响应。</para>
    /// </summary>
    public class CgibinSchoolDepartmentCreateResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置部门 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public long DepartmentId { get; set; }
    }
}
