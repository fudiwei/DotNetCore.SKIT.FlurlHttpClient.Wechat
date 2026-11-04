namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/send_msg_on_event 接口的请求。</para>
    /// </summary>
    public class CgibinKfSendMessageOnEventRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class TextMessage : CgibinKfSendMessageRequest.Types.TextMessage
            {
            }

            public class MenuMessage
            {
                public static class Types
                {
                    public class MenuItem
                    {
                        public static class Types
                        {
                            public class Text : CgibinKfSendMessageRequest.Types.MenuMessage.Types.MenuItem.Types.Text
                            {
                            }

                            public class Click : CgibinKfSendMessageRequest.Types.MenuMessage.Types.MenuItem.Types.Click
                            {
                            }

                            public class View : CgibinKfSendMessageRequest.Types.MenuMessage.Types.MenuItem.Types.View
                            {
                            }

                            public class MiniProgram : CgibinKfSendMessageRequest.Types.MenuMessage.Types.MenuItem.Types.MiniProgram
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置菜单类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string? Type { get; set; }

                        /// <summary>
                        /// 获取或设置文本信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text")]
                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                        public Types.Text? Text { get; set; }

                        /// <summary>
                        /// 获取或设置点击项信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("click")]
                        [System.Text.Json.Serialization.JsonPropertyName("click")]
                        public Types.Click? Click { get; set; }

                        /// <summary>
                        /// 获取或设置跳转项信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("view")]
                        [System.Text.Json.Serialization.JsonPropertyName("view")]
                        public Types.View? View { get; set; }

                        /// <summary>
                        /// 获取或设置小程序项信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("miniprogram")]
                        [System.Text.Json.Serialization.JsonPropertyName("miniprogram")]
                        public Types.MiniProgram? MiniProgram { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置头部内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_content")]
                [System.Text.Json.Serialization.JsonPropertyName("head_content")]
                public string? HeadContent { get; set; }

                /// <summary>
                /// 获取或设置菜单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public List<Types.MenuItem>? List { get; set; }

                /// <summary>
                /// 获取或设置尾部内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tail_content")]
                [System.Text.Json.Serialization.JsonPropertyName("tail_content")]
                public string? TailContent { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置事件响应消息对用的 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? MessageCode { get; set; }

        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgid")]
        [System.Text.Json.Serialization.JsonPropertyName("msgid")]
        public string? MessageId { get; set; }

        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgtype")]
        [System.Text.Json.Serialization.JsonPropertyName("msgtype")]
        public string? MessageType { get; set; }

        /// <summary>
        /// 获取或设置文本消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text")]
        [System.Text.Json.Serialization.JsonPropertyName("text")]
        public Types.TextMessage? MessageContentAsText { get; set; }

        /// <summary>
        /// 获取或设置菜单消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgmenu")]
        [System.Text.Json.Serialization.JsonPropertyName("msgmenu")]
        public Types.MenuMessage? MessageContentAsMenu { get; set; }
    }
}
