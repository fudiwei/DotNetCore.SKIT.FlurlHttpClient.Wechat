namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/gettriggers 接口的响应。</para>
    /// </summary>
    public class ComponentTCBGetTriggersResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Trigger
            {
                /// <summary>
                /// 获取或设置触发器名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trigger_name")]
                [System.Text.Json.Serialization.JsonPropertyName("trigger_name")]
                public string TriggerName { get; set; } = default!;

                /// <summary>
                /// 获取或设置触发器触发周期。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("config")]
                [System.Text.Json.Serialization.JsonPropertyName("config")]
                public string Config { get; set; } = default!;

                /// <summary>
                /// 获取或设置触发器类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置触发器列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("triggers")]
        [System.Text.Json.Serialization.JsonPropertyName("triggers")]
        public Types.Trigger[] TriggerList { get; set; } = default!;
    }
}
