namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/groupchat/get 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGroupChatGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class GroupChat
            {
                public static class Types
                {
                    public class Member
                    {
                        public static class Types
                        {
                            public class Invitor
                            {
                                /// <summary>
                                /// 获取或设置邀请者成员账号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("userid")]
                                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                                public string UserId { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置成员类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置成员账号或外部联系人账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public string UserId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置外部联系人 UnionId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unionid")]
                        [System.Text.Json.Serialization.JsonPropertyName("unionid")]
                        public string? UnionId { get; set; }

                        /// <summary>
                        /// 获取或设置邀请者信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("invitor")]
                        [System.Text.Json.Serialization.JsonPropertyName("invitor")]
                        public Types.Invitor? Invitor { get; set; }

                        /// <summary>
                        /// 获取或设置成员名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string? Name { get; set; }

                        /// <summary>
                        /// 获取或设置成员群昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("group_nickname")]
                        [System.Text.Json.Serialization.JsonPropertyName("group_nickname")]
                        public string? GroupNickname { get; set; }

                        /// <summary>
                        /// 获取或设置入群场景值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("join_scene")]
                        [System.Text.Json.Serialization.JsonPropertyName("join_scene")]
                        public int JoinScene { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置入群时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("join_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("join_time")]
                        public long JoinTimestamp { get; set; }
                    }

                    public class Administrator
                    {
                        /// <summary>
                        /// 获取或设置管理员成员账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public string UserId { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置客户群 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("chat_id")]
                public string GroupChatId { get; set; } = default!;

                /// <summary>
                /// 获取或设置客户群名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置群主成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("owner")]
                [System.Text.Json.Serialization.JsonPropertyName("owner")]
                public string OwnerUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置群公告。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("notice")]
                [System.Text.Json.Serialization.JsonPropertyName("notice")]
                public string Notice { get; set; } = default!;

                /// <summary>
                /// 获取或设置群成员列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("member_list")]
                [System.Text.Json.Serialization.JsonPropertyName("member_list")]
                public Types.Member[] MemberList { get; set; } = default!;

                /// <summary>
                /// 获取或设置群管理员列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("admin_list")]
                [System.Text.Json.Serialization.JsonPropertyName("admin_list")]
                public Types.Administrator[] AdministratorList { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置客户群信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_chat")]
        [System.Text.Json.Serialization.JsonPropertyName("group_chat")]
        public Types.GroupChat GroupChat { get; set; } = default!;
    }
}
