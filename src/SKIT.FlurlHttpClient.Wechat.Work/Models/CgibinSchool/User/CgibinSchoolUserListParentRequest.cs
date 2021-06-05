using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/school/user/list_parent 接口的请求。</para>
    /// </summary>
    public class CgibinSchoolUserListParentRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置部门 ID（即班级）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int DeparmentId { get; set; }
    }
}
