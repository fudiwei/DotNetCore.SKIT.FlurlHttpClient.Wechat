using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/createcontainerservice 接口的请求。</para>
    /// </summary>
    public class ComponentTcbCreateContainerServiceRequest : WechatApiRequest, IMapResponse<ComponentTcbCreateContainerServiceRequest, ComponentTcbCreateContainerServiceResponse>
    {
        public static class Types
        {
            public class VPC
            {
                /// <summary>
                /// 获取或设置 VPC 唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("vpcid")]
                [System.Text.Json.Serialization.JsonPropertyName("vpcid")]
                public string VPCId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置子网 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subnetids")]
                [System.Text.Json.Serialization.JsonPropertyName("subnetids")]
                public IList<string> SubnetIdList { get; set; } = new List<string>();

                /// <summary>
                /// 获取或设置创建类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_type")]
                [System.Text.Json.Serialization.JsonPropertyName("create_type")]
                public int CreateType { get; set; }
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
        /// 获取或设置服务名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_name")]
        [System.Text.Json.Serialization.JsonPropertyName("service_name")]
        public string ServiceName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置 VPC 信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vpc")]
        [System.Text.Json.Serialization.JsonPropertyName("vpc")]
        public Types.VPC? VPC { get; set; }
    }
}
