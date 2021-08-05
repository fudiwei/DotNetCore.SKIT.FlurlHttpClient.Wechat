using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/describeenvs 接口的响应。</para>
    /// </summary>
    public class ComponentTcbDescribeEnvironmentsResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Environment
            {
                /// <summary>
                /// 获取或设置环境 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("env")]
                [System.Text.Json.Serialization.JsonPropertyName("env")]
                public string EnvironmentId { get; set; } = default!;

                /// <summary>
                /// 获取或设置环境别名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("alias")]
                [System.Text.Json.Serialization.JsonPropertyName("alias")]
                public string Alias { get; set; } = default!;

                /// <summary>
                /// 获取或设置环境状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置产品套餐 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_id")]
                [System.Text.Json.Serialization.JsonPropertyName("package_id")]
                public string? PackageId { get; set; }

                /// <summary>
                /// 获取或设置产品套餐名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_name")]
                [System.Text.Json.Serialization.JsonPropertyName("package_name")]
                public string? PackageName { get; set; }

                /// <summary>
                /// 获取或设置数据库实例 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dbinstance_id")]
                [System.Text.Json.Serialization.JsonPropertyName("dbinstance_id")]
                public string? DbInstanceId { get; set; }

                /// <summary>
                /// 获取或设置静态存储桶 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bucket_id")]
                [System.Text.Json.Serialization.JsonPropertyName("bucket_id")]
                public string? BucketId { get; set; }

                /// <summary>
                /// 获取或设置修改时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset UpdateTime { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置环境列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("info_list")]
        public Types.Environment[] EnvironmentList { get; set; } = default!;
    }
}
