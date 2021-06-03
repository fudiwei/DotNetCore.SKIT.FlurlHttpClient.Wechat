using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/message/send 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactMessageSendResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置无效的外部联系人账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_external_user")]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_external_user")]
        public string[]? InvalidExternalUserIdList { get; set; }

        /// <summary>
        /// 获取或设置无效的家长账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_parent_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_parent_userid")]
        public string[]? InvalidParentUserIdList { get; set; }

        /// <summary>
        /// 获取或设置无效的学生账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_student_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_student_userid")]
        public string[]? InvalidStudentUserIdList { get; set; }

        /// <summary>
        /// 获取或设置无效的部门 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_party")]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_party")]
        public int[]? InvalidDepartmentIdIdList { get; set; }
    }
}
