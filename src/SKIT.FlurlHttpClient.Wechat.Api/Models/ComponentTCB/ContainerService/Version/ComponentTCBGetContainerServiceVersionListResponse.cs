using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/getcsversionlist 接口的响应。</para>
    /// </summary>
    public class ComponentTCBGetContainerServiceVersionListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Version
            {
                /// <summary>
                /// 获取或设置版本名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("version_name")]
                [System.Text.Json.Serialization.JsonPropertyName("version_name")]
                public string VersionName { get; set; } = default!;

                /// <summary>
                /// 获取或设置版本状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置流量占比。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("flow_ratio")]
                [System.Text.Json.Serialization.JsonPropertyName("flow_ratio")]
                public int FlowRatio { get; set; }

                /// <summary>
                /// 获取或设置构建 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("buildid")]
                [System.Text.Json.Serialization.JsonPropertyName("buildid")]
                public int BuildId { get; set; }

                /// <summary>
                /// 获取或设置上传类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("upload_type")]
                [System.Text.Json.Serialization.JsonPropertyName("upload_type")]
                public string UploadType { get; set; } = default!;

                /// <summary>
                /// 获取或设置最小副本数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("min_replicas")]
                [System.Text.Json.Serialization.JsonPropertyName("min_replicas")]
                public int MinReplicas { get; set; }

                /// <summary>
                /// 获取或设置最大副本数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_replicas")]
                [System.Text.Json.Serialization.JsonPropertyName("max_replicas")]
                public int MaxReplicas { get; set; }

                /// <summary>
                /// 获取或设置修改时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("updated_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("updated_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset UpdateTime { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("created_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("created_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置版本列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items")]
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public Types.Version[] VersionList { get; set; } = default!;

        /// <summary>
        /// 获取或设置云函数总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int TotalCount { get; set; }
    }
}
