namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/keyword/update_rule 接口的请求。</para>
    /// </summary>
    public class CgibinChatDataKeywordUpdateRuleRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class KeywordList : CgibinChatDataKeywordCreateRuleRequest.Types.KeywordList
            {
            }

            public class SemanticsList : CgibinChatDataKeywordCreateRuleRequest.Types.SemanticsList
            {
            }

            public class ApplicableRange
            {
                public static class Types
                {
                    public class TargetTypeInfo : CgibinChatDataKeywordCreateRuleRequest.Types.ApplicableRange.Types.TargetTypeInfo
                    {
                    }

                    public class ChatTypeInfo : CgibinChatDataKeywordCreateRuleRequest.Types.ApplicableRange.Types.ChatTypeInfo
                    {
                    }

                    public class DepartmentInfo : CgibinChatDataKeywordCreateRuleRequest.Types.ApplicableRange.Types.DepartmentInfo
                    {
                    }

                    public class GroupChatInfo : CgibinChatDataKeywordCreateRuleRequest.Types.ApplicableRange.Types.GroupChatInfo
                    {
                    }

                    public class UserInfo : CgibinChatDataKeywordCreateRuleRequest.Types.ApplicableRange.Types.UserInfo
                    {
                    }

                    public class ExternalContactInfo : CgibinChatDataKeywordCreateRuleRequest.Types.ApplicableRange.Types.ExternalContactInfo
                    {
                    }

                    public class SessionTypeInfo : CgibinChatDataKeywordCreateRuleRequest.Types.ApplicableRange.Types.DepartmentInfo
                    {
                    }

                    public class ExcludeMobileList : CgibinChatDataKeywordCreateRuleRequest.Types.ApplicableRange.Types.ExcludeMobileList
                    {
                    }

                    public class ExcludeEmailList : CgibinChatDataKeywordCreateRuleRequest.Types.ApplicableRange.Types.ExcludeEmailList
                    {
                    }

                    public class ExcludeBankCardList : CgibinChatDataKeywordCreateRuleRequest.Types.ApplicableRange.Types.ExcludeBankCardList
                    {
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
        /// 获取或设置关键词规则 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_id")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_id")]
        public string RuleId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置规则名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 获取或设置关键词列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword")]
        [System.Text.Json.Serialization.JsonPropertyName("keyword")]
        public Types.KeywordList? KeywordList { get; set; }

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
