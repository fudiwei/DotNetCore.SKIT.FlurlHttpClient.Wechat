namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/getcallbackconfig 接口的响应。</para>
    /// </summary>
    public class TCBGetCallbackConfigResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ContainerConfig : TCBSetCallbackConfigRequest.Types.ContainerConfig
                    {
                    }

                    public class FunctionConfig
                    {
                        public static class Types
                        {
                            public class Callback : TCBSetCallbackConfigRequest.Types.FunctionConfig.Types.Callback
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置是否开启。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("enable")]
                        [System.Text.Json.Serialization.JsonPropertyName("enable")]
                        public bool IsEnabled { get; set; }

                        /// <summary>
                        /// 获取或设置回调列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("callbacks")]
                        [System.Text.Json.Serialization.JsonPropertyName("callbacks")]
                        public Types.Callback[]? CallbackList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置云托管配置信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("container_config")]
                [System.Text.Json.Serialization.JsonPropertyName("container_config")]
                public Types.ContainerConfig Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置云函数配置信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("function_config")]
                [System.Text.Json.Serialization.JsonPropertyName("function_config")]
                public Types.FunctionConfig FunctionConfig { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
