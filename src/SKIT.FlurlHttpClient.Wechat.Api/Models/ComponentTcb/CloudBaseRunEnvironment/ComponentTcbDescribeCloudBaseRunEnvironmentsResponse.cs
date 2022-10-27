using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/describecloudbaserunenvs 接口的响应。</para>
    /// </summary>
    public class ComponentTcbDescribeCloudBaseRunEnvironmentsResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Environment
            {
                public static class Types
                {
                    public class Database
                    {
                        /// <summary>
                        /// 获取或设置数据库所属地域。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("region")]
                        [System.Text.Json.Serialization.JsonPropertyName("region")]
                        public string Region { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置数据库唯一标识。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("instance_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("instance_id")]
                        public string InstanceId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string Status { get; set; } = default!;
                    }

                    public class Storage
                    {
                        /// <summary>
                        /// 获取或设置存储所属地域。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("region")]
                        [System.Text.Json.Serialization.JsonPropertyName("region")]
                        public string Region { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置桶名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bucket")]
                        [System.Text.Json.Serialization.JsonPropertyName("bucket")]
                        public string Bucket { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 CDN 域名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cdn_domain")]
                        [System.Text.Json.Serialization.JsonPropertyName("cdn_domain")]
                        public string? CDNDomain { get; set; }

                        /// <summary>
                        /// 获取或设置资源所属用户的腾讯云 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                        public string? AppId { get; set; }
                    }

                    public class StaticStorage
                    {
                        /// <summary>
                        /// 获取或设置静态资源所属地域。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("region")]
                        [System.Text.Json.Serialization.JsonPropertyName("region")]
                        public string Region { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置存储桶名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bucket")]
                        [System.Text.Json.Serialization.JsonPropertyName("bucket")]
                        public string Bucket { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置资源状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string Status { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置静态 CDN 域名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("static_domain")]
                        [System.Text.Json.Serialization.JsonPropertyName("static_domain")]
                        public string StaticDomain { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置静态 CDN 默认文件夹。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("default_dir_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("default_dir_name")]
                        public string DefaultDirectoryName { get; set; } = default!;
                    }

                    public class Function
                    {
                        /// <summary>
                        /// 获取或设置函数所属地域。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("region")]
                        [System.Text.Json.Serialization.JsonPropertyName("region")]
                        public string Region { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置命名空间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("namespace")]
                        [System.Text.Json.Serialization.JsonPropertyName("namespace")]
                        public string Namespace { get; set; } = default!;
                    }

                    public class LogService
                    {
                        /// <summary>
                        /// 获取或设置日志所属地域。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("region")]
                        [System.Text.Json.Serialization.JsonPropertyName("region")]
                        public string Region { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置日志 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("logset_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("logset_id")]
                        public string LogsetId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置日志名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("logset_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("logset_name")]
                        public string LogsetName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置主题 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("topic_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("topic_id")]
                        public string TopicId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置主题名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("topic_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("topic_name")]
                        public string TopicName { get; set; } = default!;
                    }

                    public class CustomLogService
                    {
                        /// <summary>
                        /// 获取或设置静态资源所属地域。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cls_region")]
                        [System.Text.Json.Serialization.JsonPropertyName("cls_region")]
                        public string Region { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置日志 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cls_logset_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("cls_logset_id")]
                        public string LogsetId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置主题 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cls_topic_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("cls_topic_id")]
                        public string TopicId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创建时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                        public DateTimeOffset CreateTime { get; set; }
                    }

                    public class Tag
                    {
                        /// <summary>
                        /// 获取或设置标签键。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("key")]
                        [System.Text.Json.Serialization.JsonPropertyName("key")]
                        public string Key { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置标签值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public string Value { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置环境所属地域。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("region")]
                [System.Text.Json.Serialization.JsonPropertyName("region")]
                public string Region { get; set; } = default!;

                /// <summary>
                /// 获取或设置环境 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("env_id")]
                [System.Text.Json.Serialization.JsonPropertyName("env_id")]
                public string EnvironmentId { get; set; } = default!;

                /// <summary>
                /// 获取或设置环境来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source")]
                [System.Text.Json.Serialization.JsonPropertyName("source")]
                public string Source { get; set; } = default!;

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
                /// 获取或设置数据库列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("databases")]
                [System.Text.Json.Serialization.JsonPropertyName("databases")]
                public Types.Database[]? DatabaseList { get; set; }

                /// <summary>
                /// 获取或设置存储列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("storages")]
                [System.Text.Json.Serialization.JsonPropertyName("storages")]
                public Types.Storage[]? StorageList { get; set; }

                /// <summary>
                /// 获取或设置静态资源列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("static_storages")]
                [System.Text.Json.Serialization.JsonPropertyName("static_storages")]
                public Types.StaticStorage[]? StaticStorageList { get; set; }

                /// <summary>
                /// 获取或设置函数列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("functions")]
                [System.Text.Json.Serialization.JsonPropertyName("functions")]
                public Types.Function[]? FunctionList { get; set; }

                /// <summary>
                /// 获取或设置云日志服务列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("log_services")]
                [System.Text.Json.Serialization.JsonPropertyName("log_services")]
                public Types.LogService[]? LogServiceList { get; set; }

                /// <summary>
                /// 获取或设置自定义日志服务列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_log_services")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_log_services")]
                public Types.CustomLogService[]? CustomLogServiceList { get; set; }

                /// <summary>
                /// 获取或设置是否到期自动降为免费版。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_auto_degrade")]
                [System.Text.Json.Serialization.JsonPropertyName("is_auto_degrade")]
                public bool IsAutoDegrade { get; set; }

                /// <summary>
                /// 获取或设置环境渠道。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("env_channel")]
                [System.Text.Json.Serialization.JsonPropertyName("env_channel")]
                public string? EnvironmentChannel { get; set; }

                /// <summary>
                /// 获取或设置支付方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_mode")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_mode")]
                public string PayMode { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否为默认环境。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_default")]
                [System.Text.Json.Serialization.JsonPropertyName("is_default")]
                public bool IsDefault { get; set; }

                /// <summary>
                /// 获取或设置环境标签列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tags")]
                [System.Text.Json.Serialization.JsonPropertyName("tags")]
                public Types.Tag[] TagList { get; set; } = default!;

                /// <summary>
                /// 获取或设置修改时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                public DateTimeOffset UpdateTime { get; set; }

                /// <summary>
                /// 获取或设置创建时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置环境列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env_list")]
        [System.Text.Json.Serialization.JsonPropertyName("env_list")]
        public Types.Environment[] EnvironmentList { get; set; } = default!;
    }
}
