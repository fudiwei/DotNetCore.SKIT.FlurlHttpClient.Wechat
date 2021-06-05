using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/user/batch_delete_student 接口的请求。</para>
    /// </summary>
    public class CgibinSchoolUserBatchDeleteStudentRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置学生账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("useridlist")]
        [System.Text.Json.Serialization.JsonPropertyName("useridlist")]
        public IList<string> StudentUserIdList { get; set; } = new List<string>();
    }
}
