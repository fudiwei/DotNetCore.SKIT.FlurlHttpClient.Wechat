using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/gettemplatelist 接口的响应。</para>
    /// </summary>
    public class WxaGetTemplateListResponse : WechatApiResponse
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
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedStringConverter))]
                public string TemplateId { get; set; } = default!;

                /// <summary>
                /// 获取或设置模板类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_type")]
                [System.Text.Json.Serialization.JsonPropertyName("template_type")]
                public int TemplateType { get; set; }

                /// <summary>
                /// 获取或设置用户自定义版本号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_version")]
                [System.Text.Json.Serialization.JsonPropertyName("user_version")]
                public string UserVersion { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户自定义版本描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("user_desc")]
                public string UserDescription { get; set; } = default!;

                /// <summary>
                /// 获取或设置添加为模板的时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
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
