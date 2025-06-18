namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/game/content_spam/media_check_sync 接口的响应。</para>
    /// </summary>
    public class WxaGameContentSpamMediaCheckSyncResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置建议类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("suggest")]
                [System.Text.Json.Serialization.JsonPropertyName("suggest")]
                public string SuggestType { get; set; } = default!;

                /// <summary>
                /// 获取或设置命中标签枚举值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("label")]
                [System.Text.Json.Serialization.JsonPropertyName("label")]
                public int Label { get; set; }
            }

            public class Detail
            {
                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errcode")]
                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置策略类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("strategy")]
                [System.Text.Json.Serialization.JsonPropertyName("strategy")]
                public string Strategy { get; set; } = default!;

                /// <summary>
                /// 获取或设置建议类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("suggest")]
                [System.Text.Json.Serialization.JsonPropertyName("suggest")]
                public string? SuggestType { get; set; }

                /// <summary>
                /// 获取或设置命中标签枚举值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("label")]
                [System.Text.Json.Serialization.JsonPropertyName("label")]
                public int? Label { get; set; }

                /// <summary>
                /// 获取或设置置信度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("prob")]
                [System.Text.Json.Serialization.JsonPropertyName("prob")]
                public int? Probability { get; set; }
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
