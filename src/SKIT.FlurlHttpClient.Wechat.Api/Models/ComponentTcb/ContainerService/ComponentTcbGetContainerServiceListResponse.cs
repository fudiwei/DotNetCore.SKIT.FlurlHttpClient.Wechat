using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/getcslist 接口的响应。</para>
    /// </summary>
    public class ComponentTcbGetContainerServiceListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class ContainerService
            {
                /// <summary>
                /// 获取或设置服务名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("server_name")]
                [System.Text.Json.Serialization.JsonPropertyName("server_name")]
                public string ServiceName { get; set; } = default!;

                /// <summary>
                /// 获取或设置 VPC 唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("vpcid")]
                [System.Text.Json.Serialization.JsonPropertyName("vpcid")]
                public string VPCId { get; set; } = default!;

                /// <summary>
                /// 获取或设置服务状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置镜像地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_repo")]
                [System.Text.Json.Serialization.JsonPropertyName("image_repo")]
                public string? ImageRepository { get; set; }

                /// <summary>
                /// 获取或设置修改时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("updated_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("updated_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset UpdateTime { get; set; }

                /// <summary>
                /// 获取或设置创建时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("created_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("created_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置云托管服务列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cslist")]
        [System.Text.Json.Serialization.JsonPropertyName("cslist")]
        public Types.ContainerService[] ContainerServiceList { get; set; } = default!;

        /// <summary>
        /// 获取或设置云函数总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int TotalCount { get; set; }
    }
}
