namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/api/get_welcome_msg 接口的响应。</para>
    /// </summary>
    public class ApiGetWelcomeMessageResponse : WechatOpenAIThirdPartyResponse<ApiGetWelcomeMessageResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class WelcomeMessage
                    {
                        /// <summary>
                        /// 获取或设置来源类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("source")]
                        [System.Text.Json.Serialization.JsonPropertyName("source")]
                        public int Source { get; set; }

                        /// <summary>
                        /// 获取或设置欢迎语 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("msgId")]
                        [System.Text.Json.Serialization.JsonPropertyName("msgId")]
                        public string MessageId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置欢迎语类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("msgType")]
                        [System.Text.Json.Serialization.JsonPropertyName("msgType")]
                        public string MessageType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置欢迎语内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("welcomeMsg")]
                        [System.Text.Json.Serialization.JsonPropertyName("welcomeMsg")]
                        public string MessageContent { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置标签。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("label")]
                        [System.Text.Json.Serialization.JsonPropertyName("label")]
                        public string? Label { get; set; }

                        /// <summary>
                        /// 获取或设置发送间隔（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("newSendInterval")]
                        [System.Text.Json.Serialization.JsonPropertyName("newSendInterval")]
                        public int SendInterval { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置欢迎语列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.WelcomeMessage[] WelcomeMessageList { get; set; } = default!;

                /// <summary>
                /// 获取或设置欢迎语总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
            }
        }
    }
}
