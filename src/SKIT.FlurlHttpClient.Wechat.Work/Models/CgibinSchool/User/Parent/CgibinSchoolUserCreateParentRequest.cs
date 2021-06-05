using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/user/create_parent 接口的请求。</para>
    /// </summary>
    public class CgibinSchoolUserCreateParentRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Child
            {
                /// <summary>
                /// 获取或设置学生账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("student_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("student_userid")]
                public string StudentUserId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置家长与学生的关系。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("relation")]
                [System.Text.Json.Serialization.JsonPropertyName("relation")]
                public string Relation { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置家长账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parent_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("parent_userid")]
        public string ParentUserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置手机号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        [System.Text.Json.Serialization.JsonPropertyName("mobile")]
        public string MobileNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否发起邀请。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_invite")]
        [System.Text.Json.Serialization.JsonPropertyName("to_invite")]
        public bool? RequireInvite { get; set; }

        /// <summary>
        /// 获取或设置家长的孩子列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("children")]
        [System.Text.Json.Serialization.JsonPropertyName("children")]
        public IList<Types.Child> Children { get; set; } = new List<Types.Child>();
    }
}
