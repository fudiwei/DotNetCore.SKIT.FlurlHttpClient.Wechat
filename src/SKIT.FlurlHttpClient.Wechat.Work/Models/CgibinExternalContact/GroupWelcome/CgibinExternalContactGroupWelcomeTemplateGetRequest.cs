using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/group_welcome_template/get 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactGroupWelcomeTemplateGetRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置欢迎语素材 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string TemplateId { get; set; } = string.Empty;
    }
}
