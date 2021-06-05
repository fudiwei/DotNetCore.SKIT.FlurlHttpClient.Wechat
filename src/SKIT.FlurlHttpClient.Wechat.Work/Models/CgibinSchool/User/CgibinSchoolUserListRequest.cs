using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/school/user/list 接口的请求。</para>
    /// </summary>
    public class CgibinSchoolUserListRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置部门 ID（即班级）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int DeparmentId { get; set; }

        /// <summary>
        /// 获取或设置是否递归获取子部门成员。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public bool? RequireFetchChild { get; set; }
    }
}
