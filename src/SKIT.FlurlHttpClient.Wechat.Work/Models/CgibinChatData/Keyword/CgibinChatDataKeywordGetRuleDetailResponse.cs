namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/keyword/get_rule_detail 接口的响应。</para>
    /// </summary>
    public class CgibinChatDataKeywordGetRuleDetailResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class KeywordList
            {
                /// <summary>
                /// 获取或设置关键词列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("word_list")]
                [System.Text.Json.Serialization.JsonPropertyName("word_list")]
                public string[] Items { get; set; } = default!;
            }

            public class SemanticsList
            {
                /// <summary>
                /// 获取或设置关键行为列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("semantics_list")]
                [System.Text.Json.Serialization.JsonPropertyName("semantics_list")]
                public int[] Items { get; set; } = default!;
            }

            public class ApplicableRange
            {
                public static class Types
                {
                    public class TargetTypeInfo
                    {
                        /// <summary>
                        /// 获取或设置对象类型列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("type_list")]
                        public int[]? TypeList { get; set; }
                    }

                    public class ChatTypeInfo
                    {
                        /// <summary>
                        /// 获取或设置会话类型列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("type_list")]
                        public int[]? TypeList { get; set; }
                    }

                    public class DepartmentInfo
                    {
                        /// <summary>
                        /// 获取或设置部门 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_list")]
                        public long[]? DepartmentIdList { get; set; }
                    }

                    public class GroupChatInfo
                    {
                        /// <summary>
                        /// 获取或设置群 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_list")]
                        public string[]? GroupChatIdList { get; set; }
                    }

                    public class UserInfo
                    {
                        /// <summary>
                        /// 获取或设置成员账号列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_list")]
                        public string[]? UserIdList { get; set; }
                    }

                    public class ExternalContactInfo
                    {
                        /// <summary>
                        /// 获取或设置外部联系人 UserId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_list")]
                        public string[]? ExternalUserIdList { get; set; }
                    }

                    public class SessionTypeInfo
                    {
                        /// <summary>
                        /// 获取或设置会话范围列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("session_type_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("session_type_list")]
                        public int[]? SessionTypeList { get; set; }
                    }

                    public class ExcludeMobileList
                    {
                        /// <summary>
                        /// 获取或设置手机号码列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mobile_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("mobile_list")]
                        public string[]? Items { get; set; }
                    }

                    public class ExcludeEmailList
                    {
                        /// <summary>
                        /// 获取或设置邮箱列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("email_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("email_list")]
                        public string[]? Items { get; set; }
                    }

                    public class ExcludeBankCardList
                    {
                        /// <summary>
                        /// 获取或设置银行卡号列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bank_card_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("bank_card_list")]
                        public string[]? Items { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置适用的对象类型信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("target_type")]
                [System.Text.Json.Serialization.JsonPropertyName("target_type")]
                public Types.TargetTypeInfo? TargetTypeInfo { get; set; }

                /// <summary>
                /// 获取或设置适用的会话类型信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chat_type")]
                [System.Text.Json.Serialization.JsonPropertyName("chat_type")]
                public Types.ChatTypeInfo? ChatTypeInfo { get; set; }

                /// <summary>
                /// 获取或设置适用的部门信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("department")]
                [System.Text.Json.Serialization.JsonPropertyName("department")]
                public Types.DepartmentInfo? DepartmentInfo { get; set; }

                /// <summary>
                /// 获取或设置适用的员工信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user")]
                [System.Text.Json.Serialization.JsonPropertyName("user")]
                public Types.UserInfo? UserInfo { get; set; }

                /// <summary>
                /// 获取或设置适用的客户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_contact")]
                [System.Text.Json.Serialization.JsonPropertyName("external_contact")]
                public Types.ExternalContactInfo? ExternalContactInfo { get; set; }

                /// <summary>
                /// 获取或设置适用的群聊信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chat")]
                [System.Text.Json.Serialization.JsonPropertyName("chat")]
                public Types.GroupChatInfo? GroupChatInfo { get; set; }

                /// <summary>
                /// 获取或设置适用的会话范围信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("session_type")]
                [System.Text.Json.Serialization.JsonPropertyName("session_type")]
                public Types.SessionTypeInfo? SessionTypeInfo { get; set; }

                /// <summary>
                /// 获取或设置手机号码白名单信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exclude_mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("exclude_mobile")]
                public Types.ExcludeMobileList? ExcludeMobileList { get; set; }

                /// <summary>
                /// 获取或设置邮箱白名单信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exclude_email")]
                [System.Text.Json.Serialization.JsonPropertyName("exclude_email")]
                public Types.ExcludeEmailList? ExcludeEmailList { get; set; }

                /// <summary>
                /// 获取或设置银行卡号白名单信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exclude_bank_card")]
                [System.Text.Json.Serialization.JsonPropertyName("exclude_bank_card")]
                public Types.ExcludeBankCardList? ExcludeBankCardList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置规则名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 获取或设置关键词列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword")]
        [System.Text.Json.Serialization.JsonPropertyName("keyword")]
        public Types.KeywordList KeywordList { get; set; } = default!;

        /// <summary>
        /// 获取或设置关键行为列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("semantics")]
        [System.Text.Json.Serialization.JsonPropertyName("semantics")]
        public Types.SemanticsList? SemanticsList { get; set; }

        /// <summary>
        /// 获取或设置适用范围配置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applicable_range")]
        [System.Text.Json.Serialization.JsonPropertyName("applicable_range")]
        public Types.ApplicableRange? ApplicableRange { get; set; }
    }
}
