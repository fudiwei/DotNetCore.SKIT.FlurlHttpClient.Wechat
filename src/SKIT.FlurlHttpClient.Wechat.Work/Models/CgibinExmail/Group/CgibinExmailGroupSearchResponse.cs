namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/exmail/group/search 接口的响应。</para>
    /// </summary>
    public class CgibinExmailGroupSearchResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class EmailGroup
            {
                /// <summary>
                /// 获取或设置邮件群组 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("groupid")]
                [System.Text.Json.Serialization.JsonPropertyName("groupid")]
                public string GroupId { get; set; } = default!;

                /// <summary>
                /// 获取或设置邮件群组名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("groupname")]
                [System.Text.Json.Serialization.JsonPropertyName("groupname")]
                public string GroupName { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置邮件群组列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("groups")]
        [System.Text.Json.Serialization.JsonPropertyName("groups")]
        public Types.EmailGroup[] EmailGroupList { get; set; } = default!;
    }
}
