using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/updatescfconfig 接口的请求。</para>
    /// </summary>
    public class ComponentTcbUploadSCFConfigRequest : WechatApiRequest, IMapResponse<ComponentTcbUploadSCFConfigRequest, ComponentTcbUploadSCFConfigResponse>
    {
        public static class Types
        {
            public class EnvironmentVariable
            {
                /// <summary>
                /// 获取或设置键。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("key")]
                [System.Text.Json.Serialization.JsonPropertyName("key")]
                public string Key { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }

            public class PublicNetConfig
            {
                /// <summary>
                /// 获取或公网访问状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("public_net_status")]
                [System.Text.Json.Serialization.JsonPropertyName("public_net_status")]
                public string PublicNetStatus { get; set; } = string.Empty;

                /// <summary>
                /// 获取或 EIP 状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("eip_status")]
                [System.Text.Json.Serialization.JsonPropertyName("eip_status")]
                public string EIPStatus { get; set; } = string.Empty;
            }

            public class VPCConfig
            {
                /// <summary>
                /// 获取或设置 VPC 唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("vpcid")]
                [System.Text.Json.Serialization.JsonPropertyName("vpcid")]
                public string VPCId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置子网 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subnetid")]
                [System.Text.Json.Serialization.JsonPropertyName("subnetid")]
                public string SubnetId { get; set; } = string.Empty;
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
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置函数名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("functionname")]
        [System.Text.Json.Serialization.JsonPropertyName("functionname")]
        public string FunctionName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置内存大小（单位：MB）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("memorysize")]
        [System.Text.Json.Serialization.JsonPropertyName("memorysize")]
        public int? FunctionMemorySize { get; set; }

        /// <summary>
        /// 获取或设置超时时间（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timeout")]
        [System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public int? FunctionTimeout { get; set; }

        /// <summary>
        /// 获取或设置环境变量列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("environment_variables")]
        [System.Text.Json.Serialization.JsonPropertyName("environment_variables")]
        public List<Types.EnvironmentVariable>? EnvironmentVariableList { get; set; }

        /// <summary>
        /// 获取或设置公网访问配置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("public_net_config")]
        [System.Text.Json.Serialization.JsonPropertyName("public_net_config")]
        public Types.PublicNetConfig? PublicNetConfig { get; set; }

        /// <summary>
        /// 获取或设置私有网络配置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vpc_config")]
        [System.Text.Json.Serialization.JsonPropertyName("vpc_config")]
        public Types.VPCConfig? VPCConfig { get; set; }
    }
}
