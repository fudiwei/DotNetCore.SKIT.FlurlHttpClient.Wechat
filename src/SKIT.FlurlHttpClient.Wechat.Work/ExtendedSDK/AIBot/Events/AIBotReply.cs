namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Events
{
    /// <summary>
    /// <para>表示企业微信智能机器人被动回复消息的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/101031 ]]>
    /// </para>
    /// </summary>
    public class AIBotReply : WechatWorkAIBotEvent
    {
        public static class Types
        {
            public class Text : Models.CgibinAIBotResponseRequest.Types.Text
            {
            }

            public class Image
            {
                /// <summary>
                /// 获取或设置图片数据的 Base64 字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base64")]
                [System.Text.Json.Serialization.JsonPropertyName("base64")]
                public string ImageDataBase64String { get; set; } = default!;

                /// <summary>
                /// 获取或设置图片数据的 MD5 值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("md5")]
                [System.Text.Json.Serialization.JsonPropertyName("md5")]
                public string ImageDataMd5 { get; set; } = default!;
            }

            public class TemplateCard : Models.CgibinAIBotResponseRequest.Types.TemplateCard
            {
            }

            public class Stream
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
                /// 获取或设置流式消息 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// 获取或设置是否结束。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("finish")]
                [System.Text.Json.Serialization.JsonPropertyName("finish")]
                public bool? IsFinished { get; set; }

                /// <summary>
                /// 获取或设置内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// 获取或设置混排消息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msg_item")]
                [System.Text.Json.Serialization.JsonPropertyName("msg_item")]
                public Types.MessageItem[] MessageItemList { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户交互反馈信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("feedback")]
                [System.Text.Json.Serialization.JsonPropertyName("feedback")]
                public Feedback? Feedback { get; set; }
            }

            public class Feedback : Models.CgibinAIBotResponseRequest.Types.Feedback
            {
            }
        }

        /// <summary>
        /// 获取或设置文本消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text")]
        [System.Text.Json.Serialization.JsonPropertyName("text")]
        public Types.Text? Text { get; set; }

        /// <summary>
        /// 获取或设置模板卡片消息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_card")]
        [System.Text.Json.Serialization.JsonPropertyName("template_card")]
        public Types.TemplateCard? TemplateCard { get; set; }

        /// <summary>
        /// 获取或设置流式消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stream")]
        [System.Text.Json.Serialization.JsonPropertyName("stream")]
        public Types.Stream? Stream { get; set; }
    }
}
