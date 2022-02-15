using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/setcsversionconfig 接口的请求。</para>
    /// </summary>
    public class ComponentTcbSetContainerServiceVersionConfigRequest : WechatApiRequest, IMapResponse<ComponentTcbSetContainerServiceVersionConfigRequest, ComponentTcbSetContainerServiceVersionConfigResponse>
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置服务名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_name")]
        [System.Text.Json.Serialization.JsonPropertyName("service_name")]
        public string ServiceName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置版本名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version_name")]
        [System.Text.Json.Serialization.JsonPropertyName("version_name")]
        public string VersionName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置最小副本数（范围：0～50）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minnum")]
        [System.Text.Json.Serialization.JsonPropertyName("minnum")]
        public int? MinReplicas { get; set; }

        /// <summary>
        /// 获取或设置最大副本数（范围：0～50）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxnum")]
        [System.Text.Json.Serialization.JsonPropertyName("maxnum")]
        public int? MaxReplicas { get; set; }

        /// <summary>
        /// 获取或设置端口号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("container_port")]
        [System.Text.Json.Serialization.JsonPropertyName("container_port")]
        public int? ContainerPort { get; set; }

        /// <summary>
        /// 获取或设置环境变量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env_params")]
        [System.Text.Json.Serialization.JsonPropertyName("env_params")]
        public string? EnvironmentVariables { get; set; }

        /// <summary>
        /// 获取或设置自定义采集日志路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_logs")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_logs")]
        public string? CustomLogPath { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }
    }
}
