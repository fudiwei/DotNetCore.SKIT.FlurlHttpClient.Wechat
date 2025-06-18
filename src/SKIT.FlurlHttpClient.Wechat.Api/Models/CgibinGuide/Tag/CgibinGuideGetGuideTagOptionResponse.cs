namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/getguidetagoption 接口的响应。</para>
    /// </summary>
    public class CgibinGuideGetGuideTagOptionResponse : WechatApiResponse
    {
        public static class Types
        {
            public class TagOption
            {
                /// <summary>
                /// 获取或设置标签类型名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tag_name")]
                [System.Text.Json.Serialization.JsonPropertyName("tag_name")]
                public string TagName { get; set; } = default!;

                /// <summary>
                /// 获取或设置标签可选值列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tag_values")]
                [System.Text.Json.Serialization.JsonPropertyName("tag_values")]
                public string[] TagValues { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置标签类型列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("options")]
        [System.Text.Json.Serialization.JsonPropertyName("options")]
        public Types.TagOption[] TagOptionList { get; set; } = default!;
    }
}
