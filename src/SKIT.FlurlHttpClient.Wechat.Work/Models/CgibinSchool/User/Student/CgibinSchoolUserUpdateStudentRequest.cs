using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/user/update_student 接口的请求。</para>
    /// </summary>
    public class CgibinSchoolUserUpdateStudentRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置学生账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("student_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("student_userid")]
        public string StudentUserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置新的学生账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_student_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("new_student_userid")]
        public string? NewStudentUserId { get; set; }

        /// <summary>
        /// 获取或设置学生姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 获取或设置学生所在的部门 ID（即班级）列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("department")]
        [System.Text.Json.Serialization.JsonPropertyName("department")]
        public IList<int>? DepartmentIdList { get; set; }
    }
}
