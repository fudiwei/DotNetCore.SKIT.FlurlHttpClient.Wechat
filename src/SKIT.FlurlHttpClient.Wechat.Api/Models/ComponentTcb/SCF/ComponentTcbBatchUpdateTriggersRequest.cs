using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/batchupdatetriggers 接口的请求。</para>
    /// </summary>
    public class ComponentTcbBatchUpdateTriggersRequest : WechatApiRequest
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
        /// 获取或设置函数名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("funcname")]
        [System.Text.Json.Serialization.JsonPropertyName("funcname")]
        public string FunctionName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置环境 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("envs")]
        [System.Text.Json.Serialization.JsonPropertyName("envs")]
        public IList<string> EnvironmentIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置触发器信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("triggers")]
        [System.Text.Json.Serialization.JsonPropertyName("triggers")]
        public IList<Types.Trigger> Trigger { get; set; } = new List<Types.Trigger>();
    }
}
