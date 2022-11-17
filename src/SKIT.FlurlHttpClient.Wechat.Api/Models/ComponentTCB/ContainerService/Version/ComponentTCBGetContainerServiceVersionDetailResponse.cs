using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/getcsversiondetail 接口的响应。</para>
    /// </summary>
    public class ComponentTCBGetContainerServiceVersionDetailResponse : WechatApiResponse
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
        /// 获取或设置上传方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_type")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_type")]
        public string UploadType { get; set; } = default!;

        /// <summary>
        /// 获取或设置 CPU 核心数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cpu")]
        [System.Text.Json.Serialization.JsonPropertyName("cpu")]
        public double CPUCount { get; set; }

        /// <summary>
        /// 获取或设置内存大小（单位：GB）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mem")]
        [System.Text.Json.Serialization.JsonPropertyName("mem")]
        public double MemorySize { get; set; }

        /// <summary>
        /// 获取或设置最小副本数（范围：0～50）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minnum")]
        [System.Text.Json.Serialization.JsonPropertyName("minnum")]
        public int MinReplicas { get; set; }

        /// <summary>
        /// 获取或设置最大副本数（范围：0～50）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxnum")]
        [System.Text.Json.Serialization.JsonPropertyName("maxnum")]
        public int MaxReplicas { get; set; }

        /// <summary>
        /// 获取或设置策略类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("policy_type")]
        [System.Text.Json.Serialization.JsonPropertyName("policy_type")]
        public string PolicyType { get; set; } = default!;

        /// <summary>
        /// 获取或设置策略阈值（范围：0～100）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("policy_threshold")]
        [System.Text.Json.Serialization.JsonPropertyName("policy_threshold")]
        public int PolicyThreshold { get; set; }

        /// <summary>
        /// 获取或设置版本 IP。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version_ip")]
        [System.Text.Json.Serialization.JsonPropertyName("version_ip")]
        public string VersionIP { get; set; } = default!;

        /// <summary>
        /// 获取或设置版本端口。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version_port")]
        [System.Text.Json.Serialization.JsonPropertyName("version_port")]
        public int VersionPort { get; set; }

        /// <summary>
        /// 获取或设置端口号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("container_port")]
        [System.Text.Json.Serialization.JsonPropertyName("container_port")]
        public int ContainerPort { get; set; }

        /// <summary>
        /// 获取或设置仓库类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("repo_type")]
        [System.Text.Json.Serialization.JsonPropertyName("repo_type")]
        public string RepositoryType { get; set; } = default!;

        /// <summary>
        /// 获取或设置仓库地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("repo")]
        [System.Text.Json.Serialization.JsonPropertyName("repo")]
        public string RepositoryUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置 Dockerfile 路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dockerfile_path")]
        [System.Text.Json.Serialization.JsonPropertyName("dockerfile_path")]
        public string DockerfilePath { get; set; } = default!;

        /// <summary>
        /// 获取或设置构建目录。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("build_dir")]
        [System.Text.Json.Serialization.JsonPropertyName("build_dir")]
        public string BuildDirectory { get; set; } = default!;

        /// <summary>
        /// 获取或设置环境变量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env_params")]
        [System.Text.Json.Serialization.JsonPropertyName("env_params")]
        public string EnvironmentVariables { get; set; } = default!;

        /// <summary>
        /// 获取或设置分支。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("branch")]
        [System.Text.Json.Serialization.JsonPropertyName("branch")]
        public string Branch { get; set; } = default!;

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置包名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_name")]
        [System.Text.Json.Serialization.JsonPropertyName("package_name")]
        public string PackageName { get; set; } = default!;

        /// <summary>
        /// 获取或设置包版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_version")]
        [System.Text.Json.Serialization.JsonPropertyName("package_version")]
        public string PackageVersion { get; set; } = default!;

        /// <summary>
        /// 获取或设置镜像地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_url")]
        [System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 获取或设置自定义采集日志路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_logs")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_logs")]
        public string? CustomLogPath { get; set; }

        /// <summary>
        /// 获取或设置修改时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("updated_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("updated_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset UpdateTime { get; set; } = default!;

        /// <summary>
        /// 获取或设置创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("created_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("created_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; } = default!;
    }
}
