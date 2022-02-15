namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.Platform
{
    /// <summary>
    /// <para>表示 [POST] /nlp/document_classify/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class NLPDocumentClassifyResponse : WechatOpenAIPlatformResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置一级分类结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level1_cls")]
                [System.Text.Json.Serialization.JsonPropertyName("level1_cls")]
                public string Level1Classification { get; set; } = default!;

                /// <summary>
                /// 获取或设置二级分类结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level2_cls")]
                [System.Text.Json.Serialization.JsonPropertyName("level2_cls")]
                public string Level2Classification { get; set; } = default!;

                /// <summary>
                /// 获取或设置三级分类结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level3_cls")]
                [System.Text.Json.Serialization.JsonPropertyName("level3_cls")]
                public string Level3lassification { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置文章分类的结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("preds")]
        [System.Text.Json.Serialization.JsonPropertyName("preds")]
        public Types.Result Result { get; set; } = default!;
    }
}
