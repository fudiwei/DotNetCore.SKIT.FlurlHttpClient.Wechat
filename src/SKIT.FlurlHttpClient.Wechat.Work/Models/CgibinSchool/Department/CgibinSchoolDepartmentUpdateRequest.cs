using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/department/update 接口的请求。</para>
    /// </summary>
    public class CgibinSchoolDepartmentUpdateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Administrator
            {
                /// <summary>
                /// 获取或设置操作类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("op")]
                [System.Text.Json.Serialization.JsonPropertyName("op")]
                public int OperationType { get; set; }

                /// <summary>
                /// 获取或设置管理员成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置管理员类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int? Type { get; set; }

                /// <summary>
                /// 获取或设置教师科目。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subject")]
                [System.Text.Json.Serialization.JsonPropertyName("subject")]
                public string? Subject { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置部门 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// 获取或设置新的部门 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_id")]
        [System.Text.Json.Serialization.JsonPropertyName("new_id")]
        public int? NewDepartmentId { get; set; }

        /// <summary>
        /// 获取或设置部门名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 获取或设置上级部门 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parentid")]
        [System.Text.Json.Serialization.JsonPropertyName("parentid")]
        public int? ParentDepartmentId { get; set; }

        /// <summary>
        /// 获取或设置标准年级。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("standard_grade")]
        [System.Text.Json.Serialization.JsonPropertyName("standard_grade")]
        public int? StandardGrade { get; set; }

        /// <summary>
        /// 获取或设置入学年份。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("register_year")]
        [System.Text.Json.Serialization.JsonPropertyName("register_year")]
        public int? RegisterYear { get; set; }

        /// <summary>
        /// 获取或设置次序值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order")]
        [System.Text.Json.Serialization.JsonPropertyName("order")]
        public long? Order { get; set; }

        /// <summary>
        /// 获取或设置部门管理员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("department_admins")]
        [System.Text.Json.Serialization.JsonPropertyName("department_admins")]
        public IList<Types.Administrator>? AdministratorList { get; set; }
    }
}
