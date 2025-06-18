namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/leads/get_leads_component_id 接口的响应。</para>
    /// </summary>
    public class ChannelsLeadsGetLeadsComponentIdResponse : WechatApiResponse
    {
        public static class Types
        {
            public class LeadsComponent
            {
                /// <summary>
                /// 获取或设置留资组件 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("leads_component_id")]
                [System.Text.Json.Serialization.JsonPropertyName("leads_component_id")]
                public string LeadsComponentId { get; set; } = default!;

                /// <summary>
                /// 获取或设置留资组件标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("leads_description")]
                [System.Text.Json.Serialization.JsonPropertyName("leads_description")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置留资组件状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置留资组件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item")]
        [System.Text.Json.Serialization.JsonPropertyName("item")]
        public Types.LeadsComponent[] LeadsComponentList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("continue_flag")]
        [System.Text.Json.Serialization.JsonPropertyName("continue_flag")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_buffer")]
        [System.Text.Json.Serialization.JsonPropertyName("last_buffer")]
        public string? NextCursor { get; set; }
    }
}
