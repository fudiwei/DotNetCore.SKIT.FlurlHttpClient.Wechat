namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/department/list 接口的响应。</para>
    /// </summary>
    public class CgibinDepartmentListResponse : WechatWorkResponse
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
                /// 获取或设置部门名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置部门英文名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name_en")]
                [System.Text.Json.Serialization.JsonPropertyName("name_en")]
                public string? EnglishName { get; set; }

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

                /// <summary>
                /// 获取或设置部门负责人成员账号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("department_leader")]
                [System.Text.Json.Serialization.JsonPropertyName("department_leader")]
                public string[]? LeaderUserIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置部门列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("department")]
        [System.Text.Json.Serialization.JsonPropertyName("department")]
        public Types.Department[] DepartmentList { get; set; } = default!;
    }
}
