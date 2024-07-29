namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/agent/get_admin_list 接口的响应。</para>
    /// </summary>
    public class CgibinAgentGetAdminListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Administrator
            {
                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置管理权限。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_type")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_type")]
                public int AuthType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置管理员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admin")]
        [System.Text.Json.Serialization.JsonPropertyName("admin")]
        public Types.Administrator[]? AdministratorList { get; set; }
    }
}
