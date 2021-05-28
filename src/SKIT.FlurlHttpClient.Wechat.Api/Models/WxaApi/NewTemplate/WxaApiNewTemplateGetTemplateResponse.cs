using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/newtmpl/gettemplate 接口的响应。</para>
    /// </summary>
    public class WxaApiNewTemplateGetTemplateResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Template
            {
                /// <summary>
                /// 获取或设置添加至帐号下的模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("priTmplId")]
                [System.Text.Json.Serialization.JsonPropertyName("priTmplId")]
                public string PrivateTemplateId { get; set; } = default!;

                /// <summary>
                /// 获取或设置模版标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置模板内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = default!;

                /// <summary>
                /// 获取或设置模板类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置模板内容示例。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("example")]
                [System.Text.Json.Serialization.JsonPropertyName("example")]
                public string? Example { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置个人模板列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Template[] TemplateList { get; set; } = default!;
    }
}
