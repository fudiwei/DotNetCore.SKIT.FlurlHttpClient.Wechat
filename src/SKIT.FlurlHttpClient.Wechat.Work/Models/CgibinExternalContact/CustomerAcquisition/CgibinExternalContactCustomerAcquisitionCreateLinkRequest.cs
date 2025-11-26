using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/customer_acquisition/create_link 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactCustomerAcquisitionCreateLinkRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Range
            {
                /// <summary>
                /// 获取或设置使用范围的成员 UserId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_list")]
                [System.Text.Json.Serialization.JsonPropertyName("user_list")]
                public IList<string>? UserIdList { get; set; }

                /// <summary>
                /// 获取或设置使用范围的部门 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("department_list")]
                [System.Text.Json.Serialization.JsonPropertyName("department_list")]
                public IList<long>? DepartmentId { get; set; }
            }

            public class PriorityOption
            {
                /// <summary>
                /// 获取或设置优先分配类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("priority_type")]
                [System.Text.Json.Serialization.JsonPropertyName("priority_type")]
                public int PriorityType { get; set; }

                /// <summary>
                /// 获取或设置成员账号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("priority_userid_list")]
                [System.Text.Json.Serialization.JsonPropertyName("priority_userid_list")]
                public IList<string>? PriorityUserIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置获客链接名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link_name")]
        [System.Text.Json.Serialization.JsonPropertyName("link_name")]
        public string LinkName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置使用范围信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("range")]
        [System.Text.Json.Serialization.JsonPropertyName("range")]
        public Types.Range? Range { get; set; }

        /// <summary>
        /// 获取或设置优先分配配置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priority_option")]
        [System.Text.Json.Serialization.JsonPropertyName("priority_option")]
        public Types.PriorityOption? PriorityOption { get; set; }

        /// <summary>
        /// 获取或设置是否无需验证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skip_verify")]
        [System.Text.Json.Serialization.JsonPropertyName("skip_verify")]
        public bool? IsSkipVerify { get; set; }

        /// <summary>
        /// 获取或设置是否标记客户添加来源为该应用创建的。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mark_source")]
        [System.Text.Json.Serialization.JsonPropertyName("mark_source")]
        public bool? IsMarkSource { get; set; }
    }
}
