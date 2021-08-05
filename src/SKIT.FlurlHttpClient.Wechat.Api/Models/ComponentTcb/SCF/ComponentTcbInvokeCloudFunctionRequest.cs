using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/invokecloudfunction 接口的请求。</para>
    /// </summary>
    public class ComponentTcbInvokeCloudFunctionRequest : WechatApiRequest
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
                public string TriggerName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置触发器触发周期。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("config")]
                [System.Text.Json.Serialization.JsonPropertyName("config")]
                public string Config { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置触发器类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string EnvironmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置函数名。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string FunctionName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置函数传入参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Data { get; set; }
    }
}
