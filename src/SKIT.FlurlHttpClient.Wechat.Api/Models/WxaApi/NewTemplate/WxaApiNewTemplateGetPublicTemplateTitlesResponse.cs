namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/newtmpl/getpubtemplatetitles 接口的响应。</para>
    /// </summary>
    public class WxaApiNewTemplateGetPublicTemplateTitlesResponse : WechatApiResponse
    {
        public static class Types
        {
            public class TemplateTitle
            {
                /// <summary>
                /// 获取或设置模板标题 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tid")]
                [System.Text.Json.Serialization.JsonPropertyName("tid")]
                public int TemplateTitleId { get; set; }

                /// <summary>
                /// 获取或设置模版标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置模板类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置模板所属类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("categoryId")]
                [System.Text.Json.Serialization.JsonPropertyName("categoryId")]
                public int CategoryId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置模板标题列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.TemplateTitle[] TemplateTitleList { get; set; } = default!;

        /// <summary>
        /// 获取或设置模板标题数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public int TotalCount { get; set; }
    }
}
