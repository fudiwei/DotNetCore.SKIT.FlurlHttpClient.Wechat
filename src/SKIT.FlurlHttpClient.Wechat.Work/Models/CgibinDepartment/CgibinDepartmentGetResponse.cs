namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/department/get 接口的响应。</para>
    /// </summary>
    public class CgibinDepartmentGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Department : CgibinDepartmentListResponse.Types.Department
            {
            }
        }

        /// <summary>
        /// 获取或设置部门信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("department")]
        [System.Text.Json.Serialization.JsonPropertyName("department")]
        public Types.Department Department { get; set; } = default!;
    }
}
