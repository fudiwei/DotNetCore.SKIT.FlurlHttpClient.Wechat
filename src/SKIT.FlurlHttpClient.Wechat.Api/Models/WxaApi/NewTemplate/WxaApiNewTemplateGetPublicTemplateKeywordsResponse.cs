using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/newtmpl/getpubtemplatekeywords 接口的响应。</para>
    /// </summary>
    public class WxaApiNewTemplateGetPublicTemplateKeywordsResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Keyword
            {
                /// <summary>
                /// 获取或设置关键词 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("kid")]
                [System.Text.Json.Serialization.JsonPropertyName("kid")]
                public int KeywordId { get; set; }

                /// <summary>
                /// 获取或设置关键词内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置关键词示例。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("example")]
                [System.Text.Json.Serialization.JsonPropertyName("example")]
                public string? Example { get; set; }

                /// <summary>
                /// 获取或设置参数类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rule")]
                [System.Text.Json.Serialization.JsonPropertyName("rule")]
                public string? Rule { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置关键词列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Keyword[] KeywordList { get; set; } = default!;
    }
}
