namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/corpgroup/corp/list_app_share_info 接口的响应。</para>
    /// </summary>
    public class CgibinCorpGroupCropListAppShareInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Agent
            {
                /// <summary>
                /// 获取或设置下级企业 CorpId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corpid")]
                [System.Text.Json.Serialization.JsonPropertyName("corpid")]
                public string CorpId { get; set; } = default!;

                /// <summary>
                /// 获取或设置下级企业名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_name")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_name")]
                public string CorpName { get; set; } = default!;

                /// <summary>
                /// 获取或设置下级企业应用 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("agentid")]
                [System.Text.Json.Serialization.JsonPropertyName("agentid")]
                public int AgentId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置下级企业应用列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corp_list")]
        [System.Text.Json.Serialization.JsonPropertyName("corp_list")]
        public Types.Agent[] AgentList { get; set; } = default!;
    }
}
