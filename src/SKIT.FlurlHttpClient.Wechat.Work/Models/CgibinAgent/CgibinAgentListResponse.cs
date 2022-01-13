namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/agent/list 接口的响应。</para>
    /// </summary>
    public class CgibinAgentListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Agent
            {
                /// <summary>
                /// 获取或设置应用 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("agentid")]
                [System.Text.Json.Serialization.JsonPropertyName("agentid")]
                public int AgentId { get; set; }

                /// <summary>
                /// 获取或设置应用名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置应用方形头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("square_logo_url")]
                [System.Text.Json.Serialization.JsonPropertyName("square_logo_url")]
                public string SquareLogoUrl { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置应用列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentlist")]
        [System.Text.Json.Serialization.JsonPropertyName("agentlist")]
        public Types.Agent[] AgentList { get; set; } = default!;
    }
}
