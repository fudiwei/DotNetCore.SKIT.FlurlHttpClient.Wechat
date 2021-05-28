using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/sendsms2 接口的请求。</para>
    /// </summary>
    public class TcbSendSmsV2Request : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 URL Link。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_link")]
        [System.Text.Json.Serialization.JsonPropertyName("url_link")]
        public string UrlLink { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置模版 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// 获取或设置模版变量列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_param_list")]
        [System.Text.Json.Serialization.JsonPropertyName("template_param_list")]
        public IList<string>? TemplatePatameterList { get; set; }

        /// <summary>
        /// 获取或设置手机号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_number_list")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_number_list")]
        public IList<string> MobileNumberList { get; set; } = new List<string>();
    }
}
