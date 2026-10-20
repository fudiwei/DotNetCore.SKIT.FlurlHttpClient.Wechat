namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Events
{
    /// <summary>
    /// <para>表示企业微信智能机器人回调事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/100719 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/101027 ]]>
    /// </para>
    /// </summary>
    public class AIBotEvent : WechatWorkAIBotEvent
    {
        public static class Types
        {
            public class From
            {
                /// <summary>
                /// 获取或设置 CorpId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corpid")]
                [System.Text.Json.Serialization.JsonPropertyName("corpid")]
                public string? CorpId { get; set; }

                /// <summary>
                /// 获取或设置 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string? UserId { get; set; }
            }

            public class Text
            {
                /// <summary>
                /// 获取或设置文本内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = default!;
            }

            public class Image
            {
                /// <summary>
                /// 获取或设置图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string Url { get; set; } = default!;
            }

            public class Mixed
            {
                public static class Types
                {
                    public class MessageItem
                    {
                        /// <summary>
                        /// 获取或设置消息类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("msgtype")]
                        [System.Text.Json.Serialization.JsonPropertyName("msgtype")]
                        public string MessageType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置文本消息信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text")]
                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                        public Text? Text { get; set; }

                        /// <summary>
                        /// 获取或设置图片消息信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image")]
                        [System.Text.Json.Serialization.JsonPropertyName("image")]
                        public Image? Image { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置混排消息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msg_item")]
                [System.Text.Json.Serialization.JsonPropertyName("msg_item")]
                public Types.MessageItem[] MessageItemList { get; set; } = default!;
            }

            public class Voice
            {
                /// <summary>
                /// 获取或设置语音转换成文本的内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = default!;
            }

            public class File
            {
                /// <summary>
                /// 获取或设置文件 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string Url { get; set; } = default!;
            }

            public class Quote
            {
                /// <summary>
                /// 获取或设置消息类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msgtype")]
                [System.Text.Json.Serialization.JsonPropertyName("msgtype")]
                public string MessageType { get; set; } = default!;

                /// <summary>
                /// 获取或设置文本消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public Text? Text { get; set; }

                /// <summary>
                /// 获取或设置图片消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image")]
                [System.Text.Json.Serialization.JsonPropertyName("image")]
                public Image? Image { get; set; }

                /// <summary>
                /// 获取或设置图文混排消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mixed")]
                [System.Text.Json.Serialization.JsonPropertyName("mixed")]
                public Mixed? Mixed { get; set; }

                /// <summary>
                /// 获取或设置语音消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("voice")]
                [System.Text.Json.Serialization.JsonPropertyName("voice")]
                public Voice? Voice { get; set; }

                /// <summary>
                /// 获取或设置文件消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file")]
                [System.Text.Json.Serialization.JsonPropertyName("file")]
                public File? File { get; set; }
            }

            public class Stream
            {
                /// <summary>
                /// 获取或设置流式消息 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string? Id { get; set; }
            }

            public class Event
            {
                public static class Types
                {
                    public class TemplateCardEvent
                    {
                        public static class Types
                        {
                            public class SelectedItemList
                            {
                                /// <summary>
                                /// 获取或设置选择的数据列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("selected_item")]
                                [System.Text.Json.Serialization.JsonPropertyName("selected_item")]
                                public SelectedItem[] Items { get; set; } = default!;
                            }

                            public class SelectedItem
                            {
                                public static class Types
                                {
                                    public class OptionIdList
                                    {
                                        /// <summary>
                                        /// 获取或设置选项 ID 列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("option_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("option_id")]
                                        public string[] Items { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置选择题 Key 值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("question_key")]
                                [System.Text.Json.Serialization.JsonPropertyName("question_key")]
                                public string QuestionKey { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置选项 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("option_ids")]
                                [System.Text.Json.Serialization.JsonPropertyName("option_ids")]
                                public Types.OptionIdList OptionIdList { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置模板卡片类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("card_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("card_type")]
                        public string CardType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置事件 Key。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("event_key")]
                        [System.Text.Json.Serialization.JsonPropertyName("event_key")]
                        public string? EventKey { get; set; }

                        /// <summary>
                        /// 获取或设置任务 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("task_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                        public string? TaskId { get; set; }

                        /// <summary>
                        /// 获取或设置选择的数据列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("selected_items")]
                        [System.Text.Json.Serialization.JsonPropertyName("selected_items")]
                        public Types.SelectedItemList? SelectedItemList { get; set; }
                    }

                    public class FeedbackEvent
                    {
                        /// <summary>
                        /// 获取或设置反馈 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string Id { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置反馈类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置反馈内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string? Content { get; set; }

                        /// <summary>
                        /// 获取或设置反馈原因类型列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("inaccurate_reason_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("inaccurate_reason_list")]
                        public int[]? InaccurateReasonTypeList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置事件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("eventtype")]
                [System.Text.Json.Serialization.JsonPropertyName("eventtype")]
                public string EventType { get; set; } = default!;

                /// <summary>
                /// 获取或设置模版卡片事件信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_card_event")]
                [System.Text.Json.Serialization.JsonPropertyName("template_card_event")]
                public Types.TemplateCardEvent? TemplateCardEvent { get; set; }

                /// <summary>
                /// 获取或设置用户反馈事件信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("feedback_event")]
                [System.Text.Json.Serialization.JsonPropertyName("feedback_event")]
                public Types.FeedbackEvent? FeedbackEvent { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgid")]
        [System.Text.Json.Serialization.JsonPropertyName("msgid")]
        public string MessageId { get; set; } = default!;

        /// <summary>
        /// 获取或设置消息触发者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("from")]
        [System.Text.Json.Serialization.JsonPropertyName("from")]
        public Types.From From { get; set; } = default!;

        /// <summary>
        /// 获取或设置会话 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chatid")]
        [System.Text.Json.Serialization.JsonPropertyName("chatid")]
        public string? ChatId { get; set; }

        /// <summary>
        /// 获取或设置会话类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chattype")]
        [System.Text.Json.Serialization.JsonPropertyName("chattype")]
        public string? ChatType { get; set; }

        /// <summary>
        /// 获取或设置机器人 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aibotid")]
        [System.Text.Json.Serialization.JsonPropertyName("aibotid")]
        public string? BotId { get; set; }

        /// <summary>
        /// 获取或设置主动回复临时 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("response_url")]
        [System.Text.Json.Serialization.JsonPropertyName("response_url")]
        public string? ResponseUrl { get; set; }

        /// <summary>
        /// 获取或设置文本消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text")]
        [System.Text.Json.Serialization.JsonPropertyName("text")]
        public Types.Text? Text { get; set; }

        /// <summary>
        /// 获取或设置图片消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image")]
        [System.Text.Json.Serialization.JsonPropertyName("image")]
        public Types.Image? Image { get; set; }

        /// <summary>
        /// 获取或设置图文混排消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mixed")]
        [System.Text.Json.Serialization.JsonPropertyName("mixed")]
        public Types.Mixed? Mixed { get; set; }

        /// <summary>
        /// 获取或设置语音消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voice")]
        [System.Text.Json.Serialization.JsonPropertyName("voice")]
        public Types.Voice? Voice { get; set; }

        /// <summary>
        /// 获取或设置文件消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file")]
        [System.Text.Json.Serialization.JsonPropertyName("file")]
        public Types.File? File { get; set; }

        /// <summary>
        /// 获取或设置引用内容信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quote")]
        [System.Text.Json.Serialization.JsonPropertyName("quote")]
        public Types.Quote? Quote { get; set; }

        /// <summary>
        /// 获取或设置流式消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stream")]
        [System.Text.Json.Serialization.JsonPropertyName("stream")]
        public Types.Stream? Stream { get; set; }

        /// <summary>
        /// 获取或设置事件消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("event")]
        [System.Text.Json.Serialization.JsonPropertyName("event")]
        public Types.Event? Event { get; set; }

        /// <summary>
        /// 获取或设置消息创建时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        public long CreateTimestamp { get; set; }
    }
}
