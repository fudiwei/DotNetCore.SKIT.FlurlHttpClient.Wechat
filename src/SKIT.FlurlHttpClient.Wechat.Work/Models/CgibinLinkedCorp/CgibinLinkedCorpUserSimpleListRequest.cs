using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/linkedcorp/user/simplelist 接口的请求。</para>
    /// </summary>
    public class CgibinLinkedCorpUserSimpleListRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置互联企业部门 ID（格式："LinkedId/DepartmentId"）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("department_id")]
        [System.Text.Json.Serialization.JsonPropertyName("department_id")]
        public string LinkedDepartmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否递归获取子部门成员。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fetch_child")]
        [System.Text.Json.Serialization.JsonPropertyName("fetch_child")]
        public bool? RequireFetchChild { get; set; }
    }
}
