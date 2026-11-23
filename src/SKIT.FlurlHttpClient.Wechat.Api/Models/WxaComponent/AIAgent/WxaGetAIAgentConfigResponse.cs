namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/getaiagentconfig 接口的响应。</para>
    /// </summary>
    public class WxaGetAIAgentConfigResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置微信 AI 开关。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ai_gui_switch")]
        [System.Text.Json.Serialization.JsonPropertyName("ai_gui_switch")]
        public string? AIGUISwitch { get; set; }

        /// <summary>
        /// 获取或设置开发模式开关。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("self_access_switch")]
        [System.Text.Json.Serialization.JsonPropertyName("self_access_switch")]
        public string? SelfAccessSwitch { get; set; }

        /// <summary>
        /// 获取或设置自动模式开关。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auto_mcp_switch")]
        [System.Text.Json.Serialization.JsonPropertyName("auto_mcp_switch")]
        public string? AutoMCPSwitch { get; set; }
    }
}
