using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/group_welcome_template/add 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGroupWelcomeTemplateAddResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置欢迎语素材 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string TemplateId { get; set; } = default!;
    }
}
