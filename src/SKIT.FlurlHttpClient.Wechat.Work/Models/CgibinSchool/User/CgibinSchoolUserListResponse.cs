using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/school/user/list 接口的响应。</para>
    /// </summary>
    public class CgibinSchoolUserListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Student : CgibinSchoolUserGetResponse.Types.Student
            {
            }
        }

        /// <summary>
        /// 获取或设置学生列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("students")]
        [System.Text.Json.Serialization.JsonPropertyName("students")]
        public Types.Student[] StudentList { get; set; } = default!;
    }
}
