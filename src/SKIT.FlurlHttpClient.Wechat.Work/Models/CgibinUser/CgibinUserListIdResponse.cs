namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/user/list_id 接口的响应。</para>
    /// </summary>
    public class CgibinUserListIdResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class DepartmentUser
            {
                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置部门 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("department")]
                [System.Text.Json.Serialization.JsonPropertyName("department")]
                public long DepartmentId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置成员与部门关系列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dept_user")]
        [System.Text.Json.Serialization.JsonPropertyName("dept_user")]
        public Types.DepartmentUser[] DepartmentUser { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
