using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/template/api_add_template 接口的请求。</para>
    /// </summary>
    public class CgibinTemplateAddTemplateRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置模板库中模板的编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id_short")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id_short")]
        public string ShortTemplateId { get; set; } = string.Empty;
    }
}
