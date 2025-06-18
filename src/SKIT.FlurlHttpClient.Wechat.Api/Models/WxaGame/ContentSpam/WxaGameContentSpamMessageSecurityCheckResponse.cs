namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/game/content_spam/msg_sec_check 接口的响应。</para>
    /// </summary>
    public class WxaGameContentSpamMessageSecurityCheckResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Result : WxaMessageSecurityCheckResponse.Types.Result
            {
                /// <summary>
                /// 获取或设置替换后的文本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("replaced_content")]
                [System.Text.Json.Serialization.JsonPropertyName("replaced_content")]
                public string ReplacedContent { get; set; } = default!;
            }

            public class Detail : WxaMessageSecurityCheckResponse.Types.Detail
            {
            }
        }

        /// <summary>
        /// 获取或设置请求跟踪标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trace_id")]
        [System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string TraceId { get; set; } = default!;

        /// <summary>
        /// 获取或设置综合结果信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public Types.Result? Result { get; set; }

        /// <summary>
        /// 获取或设置详细结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail")]
        [System.Text.Json.Serialization.JsonPropertyName("detail")]
        public Types.Detail[]? DetailList { get; set; }
    }
}
