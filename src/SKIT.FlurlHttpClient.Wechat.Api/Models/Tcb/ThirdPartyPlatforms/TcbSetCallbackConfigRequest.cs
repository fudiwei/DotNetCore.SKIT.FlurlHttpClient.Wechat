using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/setcallbackconfig 接口的请求。</para>
    /// </summary>
    public class TcbSetCallbackConfigRequest : WechatApiRequest, IMapResponse<TcbSetCallbackConfigRequest, TcbSetCallbackConfigResponse>
    {
        public static class Types
        {
            public class ContainerConfig
            {
                /// <summary>
                /// 获取或设置是否开启。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable")]
                [System.Text.Json.Serialization.JsonPropertyName("enable")]
                public bool IsEnabled { get; set; }

                /// <summary>
                /// 获取或设置环境 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qbase_env")]
                [System.Text.Json.Serialization.JsonPropertyName("qbase_env")]
                public string? EnvironmentId { get; set; }

                /// <summary>
                /// 获取或设置路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qbase_container_path")]
                [System.Text.Json.Serialization.JsonPropertyName("qbase_container_path")]
                public string? ContainerPath { get; set; }

                /// <summary>
                /// 获取或设置文本格式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text_mode")]
                [System.Text.Json.Serialization.JsonPropertyName("text_mode")]
                public int? TextMode { get; set; }
            }

            public class FunctionConfig
            {
                public static class Types
                {
                    public class Callback
                    {
                        /// <summary>
                        /// 获取或设置是否开启。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("enable")]
                        [System.Text.Json.Serialization.JsonPropertyName("enable")]
                        public bool IsEnabled { get; set; }

                        /// <summary>
                        /// 获取或设置消息类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("msgType")]
                        [System.Text.Json.Serialization.JsonPropertyName("msgType")]
                        public string MessageType { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置事件类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("event")]
                        [System.Text.Json.Serialization.JsonPropertyName("event")]
                        public string Event { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置环境 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("env")]
                        [System.Text.Json.Serialization.JsonPropertyName("env")]
                        public string EnvironmentId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置云函数名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("functionName")]
                        [System.Text.Json.Serialization.JsonPropertyName("functionName")]
                        public string FunctionName { get; set; } = string.Empty;
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
                public IList<Types.Callback>? CallbackList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置云托管配置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("container_config")]
        [System.Text.Json.Serialization.JsonPropertyName("container_config")]
        public Types.ContainerConfig? Type { get; set; }

        /// <summary>
        /// 获取或设置云函数配置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("function_config")]
        [System.Text.Json.Serialization.JsonPropertyName("function_config")]
        public Types.FunctionConfig? FunctionConfig { get; set; }
    }
}
