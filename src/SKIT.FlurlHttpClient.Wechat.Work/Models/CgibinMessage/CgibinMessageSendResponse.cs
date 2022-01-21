namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/send 接口的响应。</para>
    /// </summary>
    public class CgibinMessageSendResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置无效的成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invaliduser")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringArrayWithPipeSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("invaliduser")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringArrayWithPipeSplitConverter))]
        public string[]? InvalidUserIdList { get; set; }

        /// <summary>
        /// 获取或设置无效的部门 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalidparty")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerArrayWithPipeSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("invalidparty")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualIntegerArrayWithPipeSplitConverter))]
        public int[]? InvalidDepartmentIdList { get; set; }

        /// <summary>
        /// 获取或设置无效的标签 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalidtag")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerArrayWithPipeSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("invalidtag")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualIntegerArrayWithPipeSplitConverter))]
        public int[]? InvalidTagIdList { get; set; }

        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgid")]
        [System.Text.Json.Serialization.JsonPropertyName("msgid")]
        public string MessageId { get; set; } = default!;

        /// <summary>
        /// 获取或设置更新卡片所需要消费的 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("response_code")]
        [System.Text.Json.Serialization.JsonPropertyName("response_code")]
        public string? ResponseCode { get; set; }
    }
}
