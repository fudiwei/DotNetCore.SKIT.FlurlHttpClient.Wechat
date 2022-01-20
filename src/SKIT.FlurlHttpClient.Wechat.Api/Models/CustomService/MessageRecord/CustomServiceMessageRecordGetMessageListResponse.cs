namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /customservice/msgrecord/getmsglist 接口的响应。</para>
    /// </summary>
    public class CustomServiceMessageRecordGetMessageListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class MessageRecord
            {
                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置客服账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("worker")]
                [System.Text.Json.Serialization.JsonPropertyName("worker")]
                public string KfAccount { get; set; } = default!;

                /// <summary>
                /// 获取或设置操作码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("opercode")]
                [System.Text.Json.Serialization.JsonPropertyName("opercode")]
                public int OperateCode { get; set; }

                /// <summary>
                /// 获取或设置聊天内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public string Text { get; set; } = default!;

                /// <summary>
                /// 获取或设置操作时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time")]
                [System.Text.Json.Serialization.JsonPropertyName("time")]
                public long Timestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgid")]
        [System.Text.Json.Serialization.JsonPropertyName("msgid")]
        public long MessageId { get; set; } = 1;

        /// <summary>
        /// 获取或设置每次获取条数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("number")]
        [System.Text.Json.Serialization.JsonPropertyName("number")]
        public int Limit { get; set; } = 10;

        /// <summary>
        /// 获取或设置聊天记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recordlist")]
        [System.Text.Json.Serialization.JsonPropertyName("recordlist")]
        public Types.MessageRecord[] MessageRecordList { get; set; } = default!;
    }
}
