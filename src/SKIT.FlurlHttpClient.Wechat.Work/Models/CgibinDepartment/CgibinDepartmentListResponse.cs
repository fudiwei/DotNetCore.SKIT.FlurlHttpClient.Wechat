namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/department/list 接口的响应。</para>
    /// </summary>
    public class CgibinDepartmentListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Department : CgibinDepartmentSimpleListResponse.Types.Department
            {
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
                /// 获取或设置部门负责人成员账号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("department_leader")]
                [System.Text.Json.Serialization.JsonPropertyName("department_leader")]
                public List<string>? LeaderUserIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置部门列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("department")]
        [System.Text.Json.Serialization.JsonPropertyName("department")]
        public List<Types.Department>? DepartmentList { get; set; }
    }
}
