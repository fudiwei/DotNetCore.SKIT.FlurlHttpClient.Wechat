using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/template/get_all_private_template 接口的响应。</para>
    /// </summary>
    public class CgibinTemplateGetAllPrivateTemplateResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Template
            {
                /// <summary>
                /// 获取或设置模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                public string TemplateId { get; set; } = default!;

                /// <summary>
                /// 获取或设置模板标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置模板所属一级行业。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("primary_industry")]
                [System.Text.Json.Serialization.JsonPropertyName("primary_industry")]
                public string PrimaryIndustry { get; set; } = default!;

                /// <summary>
                /// 获取或设置模板所属二级行业。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deputy_industry")]
                [System.Text.Json.Serialization.JsonPropertyName("deputy_industry")]
                public string SecondaryIndustry { get; set; } = default!;

                /// <summary>
                /// 获取或设置模板内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = default!;

                /// <summary>
                /// 获取或设置模板示例。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("example")]
                [System.Text.Json.Serialization.JsonPropertyName("example")]
                public string? Example { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置模板列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_list")]
        [System.Text.Json.Serialization.JsonPropertyName("template_list")]
        public Types.Template[] TemplateList { get; set; } = default!;
    }
}
