namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/kf/customer/get_upgrade_service_config 接口的响应。</para>
    /// </summary>
    public class CgibinKfCustomerGetUpgradeServiceConfigResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class MemberRange
            {
                /// <summary>
                /// 获取或设置专员的 UserId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid_list")]
                [System.Text.Json.Serialization.JsonPropertyName("userid_list")]
                public string[]? UserIdList { get; set; }

                /// <summary>
                /// 获取或设置专员的部门 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("department_id_list")]
                [System.Text.Json.Serialization.JsonPropertyName("department_id_list")]
                public long[]? DepartmentIdList { get; set; }
            }

            public class GroupChatRange
            {
                /// <summary>
                /// 获取或设置客户群 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chat_id_list")]
                [System.Text.Json.Serialization.JsonPropertyName("chat_id_list")]
                public string[]? GroupChatIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置专员服务配置范围信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("member_range")]
        [System.Text.Json.Serialization.JsonPropertyName("member_range")]
        public Types.MemberRange? MemberRange { get; set; }

        /// <summary>
        /// 获取或设置客户群配置范围信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("groupchat_range")]
        [System.Text.Json.Serialization.JsonPropertyName("groupchat_range")]
        public Types.GroupChatRange? GroupChatRange { get; set; }
    }
}
