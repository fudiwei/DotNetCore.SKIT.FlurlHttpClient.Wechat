namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/department/simplelist 接口的响应。</para>
    /// </summary>
    public class CgibinDepartmentSimpleListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Department
            {
                /// <summary>
                /// 获取或设置部门 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public int DepartmentId { get; set; }

                /// <summary>
                /// 获取或设置上级部门 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parentid")]
                [System.Text.Json.Serialization.JsonPropertyName("parentid")]
                public int ParentDepartmentId { get; set; }

                /// <summary>
                /// 获取或设置在上级部门中的次序值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order")]
                [System.Text.Json.Serialization.JsonPropertyName("order")]
                public long DepartmentOrder { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置部门列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("department_id")]
        [System.Text.Json.Serialization.JsonPropertyName("department_id")]
        public Types.Department[] DepartmentList { get; set; } = default!;
    }
}
