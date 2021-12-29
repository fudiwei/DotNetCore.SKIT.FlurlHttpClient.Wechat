using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/linkedcorp/department/list 接口的响应。</para>
    /// </summary>
    public class CgibinLinkedCorpDepartmentListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class LinkedDepartment
            {
                /// <summary>
                /// 获取或设置部门 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("department_id")]
                [System.Text.Json.Serialization.JsonPropertyName("department_id")]
                public int DepartmentId { get; set; }

                /// <summary>
                /// 获取或设置部门名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("department_name")]
                [System.Text.Json.Serialization.JsonPropertyName("department_name")]
                public string? Name { get; set; }

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
        /// 获取或设置互联企业部门列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("department_list")]
        [System.Text.Json.Serialization.JsonPropertyName("department_list")]
        public Types.LinkedDepartment[] LinkedDepartmentList { get; set; } = default!;
    }
}
