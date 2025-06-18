using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/sendsms 接口的请求。</para>
    /// </summary>
    public class TCBSendSmsRequest : WechatApiRequest, IInferable<TCBSendSmsRequest, TCBSendSmsResponse>
    {
        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置手机号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_number_list")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_number_list")]
        public IList<string> MobileNumberList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置短信类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sms_type")]
        [System.Text.Json.Serialization.JsonPropertyName("sms_type")]
        public string SmsType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置自定义短信内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 获取或设置云开发静态网站 H5 页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

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
    }
}
