namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.Platform
{
    /// <summary>
    /// <para>表示 [POST] /nlp/ner/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class NLPNERResponse : WechatOpenAIPlatformResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置结果类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置范围列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("span")]
                [System.Text.Json.Serialization.JsonPropertyName("span")]
                public int[] SpanList { get; set; } = default!;

                /// <summary>
                /// 获取或设置文本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public string Text { get; set; } = default!;

                /// <summary>
                /// 获取或设置范数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("norm")]
                [System.Text.Json.Serialization.JsonPropertyName("norm")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.DynamicObjectConverter))]
                public dynamic Norm { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public Types.Result[] ResultList { get; set; } = default!;
    }
}
