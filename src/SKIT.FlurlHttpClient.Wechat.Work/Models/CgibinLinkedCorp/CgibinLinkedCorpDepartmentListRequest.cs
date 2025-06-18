namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/linkedcorp/department/list 接口的请求。</para>
    /// </summary>
    public class CgibinLinkedCorpDepartmentListRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置互联企业部门 ID（格式："LinkedId/DepartmentId"）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("department_id")]
        [System.Text.Json.Serialization.JsonPropertyName("department_id")]
        public string LinkedDepartmentId { get; set; } = string.Empty;
    }
}
