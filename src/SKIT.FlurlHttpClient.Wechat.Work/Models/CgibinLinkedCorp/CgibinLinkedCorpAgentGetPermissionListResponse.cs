using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/linkedcorp/agent/get_perm_list 接口的响应。</para>
    /// </summary>
    public class CgibinLinkedCorpAgentGetPermissionListResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置可见的互联企业成员账号（格式："CorpId/UserId"）列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userids")]
        [System.Text.Json.Serialization.JsonPropertyName("userids")]
        public string[]? CorpUserIdList { get; set; }

        /// <summary>
        /// 获取或设置可见的互联企业部门 ID（格式："LinkedId/DepartmentId"）列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("department_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("department_ids")]
        public string[]? LinkedDepartmentIdList { get; set; }
    }
}
