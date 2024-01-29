namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/get_current_autoreply_info 接口的响应。</para>
    /// </summary>
    public class CgibinGetCurrentAutoReplyInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class AutoReplyInfo
            {
                /// <summary>
                /// 获取或设置自动回复类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置自动回复内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = default!;
            }

            public class KeywordAutoReplyRuleList
            {
                /// <summary>
                /// 获取或设置关键字回复规则列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public KeywordAutoReplyRule[] Items { get; set; } = default!;
            }

            public class KeywordAutoReplyRule
            {
                public static class Types
                {
                    public class Keyword
                    {
                        /// <summary>
                        /// 获取或设置匹配模式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("match_mode")]
                        [System.Text.Json.Serialization.JsonPropertyName("match_mode")]
                        public string MatchMode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置关键词类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置关键词内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string Content { get; set; } = default!;
                    }

                    public class Reply
                    {
                        public static class Types
                        {
                            public class NewsList
                            {
                                /// <summary>
                                /// 获取或设置图文消息列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("list")]
                                [System.Text.Json.Serialization.JsonPropertyName("list")]
                                public NewsItem[] List { get; set; } = default!;
                            }

                            public class NewsItem : CgibinGetCurrentSelfMenuInfoResponse.Types.Menu.Types.Button.Types.NewsItem
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置回复类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置回复内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string? Content { get; set; }

                        /// <summary>
                        /// 获取或设置图文消息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("news_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("news_info")]
                        public Types.NewsList? NewsList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置规则名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rule_name")]
                [System.Text.Json.Serialization.JsonPropertyName("rule_name")]
                public string RuleName { get; set; } = default!;

                /// <summary>
                /// 获取或设置回复模式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reply_mode")]
                [System.Text.Json.Serialization.JsonPropertyName("reply_mode")]
                public string ReplyMode { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置匹配的关键词列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("keyword_list_info")]
                [System.Text.Json.Serialization.JsonPropertyName("keyword_list_info")]
                public Types.Keyword[] KeywordList { get; set; } = default!;

                /// <summary>
                /// 获取或设置自动回复列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reply_list_info")]
                [System.Text.Json.Serialization.JsonPropertyName("reply_list_info")]
                public Types.Reply[] ReplyList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置关注后自动回复是否开启。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_add_friend_reply_open")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_add_friend_reply_open")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool IsAddFriendReplyOpen { get; set; }

        /// <summary>
        /// 获取或设置消息自动回复是否开启。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_autoreply_open")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_autoreply_open")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool IsAutoReplyOpen { get; set; }

        /// <summary>
        /// 获取或设置关注后自动回复的信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("add_friend_autoreply_info")]
        [System.Text.Json.Serialization.JsonPropertyName("add_friend_autoreply_info")]
        public Types.AutoReplyInfo? AddFriendAutoReplyInfo { get; set; }

        /// <summary>
        /// 获取或设置消息自动回复的信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message_default_autoreply_info")]
        [System.Text.Json.Serialization.JsonPropertyName("message_default_autoreply_info")]
        public Types.AutoReplyInfo? MessageDefaultAutoReplyInfo { get; set; }

        /// <summary>
        /// 获取或设置关键字回复规则列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword_autoreply_info")]
        [System.Text.Json.Serialization.JsonPropertyName("keyword_autoreply_info")]
        public Types.KeywordAutoReplyRuleList? KeywordAutoReplyRuleList { get; set; } = default!;
    }
}
