using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/user/batch_create_parent 接口的请求。</para>
    /// </summary>
    public class CgibinSchoolUserBatchCreateParentRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Parent
            {
                public static class Types
                {
                    public class Child : CgibinSchoolUserCreateParentRequest.Types.Child
                    { 
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

        /// <summary>
        /// 获取或设置家长列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parents")]
        [System.Text.Json.Serialization.JsonPropertyName("parents")]
        public IList<Types.Parent> ParentList { get; set; } = new List<Types.Parent>();
    }
}
