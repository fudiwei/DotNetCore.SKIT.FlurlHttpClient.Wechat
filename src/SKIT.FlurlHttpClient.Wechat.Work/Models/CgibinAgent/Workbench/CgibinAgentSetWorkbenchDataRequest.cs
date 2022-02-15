namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/agent/set_workbench_data 接口的请求。</para>
    /// </summary>
    public class CgibinAgentSetWorkbenchDataRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class KeyDataTemplate : CgibinAgentSetWorkbenchTemplateRequest.Types.KeyDataTemplate
            {
            }

            public class ImageTemplate : CgibinAgentSetWorkbenchTemplateRequest.Types.ImageTemplate
            {
            }

            public class WebviewTemplate : CgibinAgentSetWorkbenchTemplateRequest.Types.WebviewTemplate
            {
            }

            public class ListTemplate : CgibinAgentSetWorkbenchTemplateRequest.Types.ListTemplate
            {
            }
        }

        /// <summary>
        /// 获取或设置应用 ID。如果不指定将使用构造 <see cref="WechatWorkClient"/> 时的 <see cref="WechatWorkClientOptions.AgentId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? AgentId { get; set; }

        /// <summary>
        /// 获取或设置成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置模版类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置关键数据型模版数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keydata")]
        [System.Text.Json.Serialization.JsonPropertyName("keydata")]
        public Types.KeyDataTemplate? KeyDataTemplate { get; set; }

        /// <summary>
        /// 获取或设置图片型模版数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image")]
        [System.Text.Json.Serialization.JsonPropertyName("image")]
        public Types.ImageTemplate? ImageTemplate { get; set; }

        /// <summary>
        /// 获取或设置列表型模版数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.ListTemplate? ListTemplate { get; set; }

        /// <summary>
        /// 获取或设置网页型模版数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webview")]
        [System.Text.Json.Serialization.JsonPropertyName("webview")]
        public Types.WebviewTemplate? WebviewTemplate { get; set; }
    }
}
