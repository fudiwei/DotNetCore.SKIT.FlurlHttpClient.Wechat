using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/rollupdatecloudbaserunserverversion 接口的请求。</para>
    /// </summary>
    public class ComponentTCBRollUpdateCloudBaseRunServerVersionRequest : WechatApiRequest, IInferable<ComponentTCBRollUpdateCloudBaseRunServerVersionRequest, ComponentTCBRollUpdateCloudBaseRunServerVersionResponse>
    {
        public static class Types
        {
            public class Image : ComponentTCBCreateCloudBaseRunServerVersionRequest.Types.Image
            {
            }

            public class Code : ComponentTCBCreateCloudBaseRunServerVersionRequest.Types.Code
            {
                public static new class Types
                {
                    public class Repository : ComponentTCBCreateCloudBaseRunServerVersionRequest.Types.Code.Types.Repository
                    {
                    }
                }

                /// <summary>
                /// 获取或设置仓库信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public new Types.Repository? Repository { get; set; }
            }

            public class VolumeMount : ComponentTCBCreateCloudBaseRunServerVersionRequest.Types.VolumeMount
            {
                public static new class Types
                {
                    public class NFSVolumeSource : ComponentTCBCreateCloudBaseRunServerVersionRequest.Types.VolumeMount.Types.NFSVolumeSource
                    {
                    }
                }

                /// <summary>
                /// 获取或设置 NFS 挂载信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nfs_volumes")]
                [System.Text.Json.Serialization.JsonPropertyName("nfs_volumes")]
                public new IList<Types.NFSVolumeSource>? NFSVolumes { get; set; }
            }

            public class HPAPolicy : ComponentTCBCreateCloudBaseRunServerVersionRequest.Types.HPAPolicy
            {
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
        [Newtonsoft.Json.JsonProperty("env_id")]
        [System.Text.Json.Serialization.JsonPropertyName("env_id")]
        public string EnvironmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置版本名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version_name")]
        [System.Text.Json.Serialization.JsonPropertyName("version_name")]
        public string VersionName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置上传类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_type")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_type")]
        public string? UploadType { get; set; }

        /// <summary>
        /// 获取或设置流量占比（范围：0～100）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("flow_ratio")]
        [System.Text.Json.Serialization.JsonPropertyName("flow_ratio")]
        public int? FlowRatio { get; set; }

        /// <summary>
        /// 获取或设置 CPU 大小（单位：核）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cpu")]
        [System.Text.Json.Serialization.JsonPropertyName("cpu")]
        public decimal? CPUSize { get; set; }

        /// <summary>
        /// 获取或设置内存大小（单位：GB）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mem")]
        [System.Text.Json.Serialization.JsonPropertyName("mem")]
        public decimal? MemorySize { get; set; }

        /// <summary>
        /// 获取或设置最小副本数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("min_num")]
        [System.Text.Json.Serialization.JsonPropertyName("min_num")]
        public int? MinNumber { get; set; }

        /// <summary>
        /// 获取或设置最大副本数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_num")]
        [System.Text.Json.Serialization.JsonPropertyName("max_num")]
        public int? MaxNumber { get; set; }

        /// <summary>
        /// 获取或设置策略类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("policy_type")]
        [System.Text.Json.Serialization.JsonPropertyName("policy_type")]
        public string? PolicyType { get; set; }

        /// <summary>
        /// 获取或设置策略阈值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("policy_threshold")]
        [System.Text.Json.Serialization.JsonPropertyName("policy_threshold")]
        public decimal? PolicyThreshold { get; set; }

        /// <summary>
        /// 获取或设置服务端口。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("container_port")]
        [System.Text.Json.Serialization.JsonPropertyName("container_port")]
        public int? ContainerPort { get; set; }

        /// <summary>
        /// 获取或设置服务名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("server_name")]
        [System.Text.Json.Serialization.JsonPropertyName("server_name")]
        public string ServerName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置仓库类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("repository_type")]
        [System.Text.Json.Serialization.JsonPropertyName("repository_type")]
        public string? RepositoryType { get; set; }

        /// <summary>
        /// 获取或设置仓库地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("repository")]
        [System.Text.Json.Serialization.JsonPropertyName("repository")]
        public string? RepositoryUrl { get; set; }

        /// <summary>
        /// 获取或设置 Dockerfile 路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dockerfile_path")]
        [System.Text.Json.Serialization.JsonPropertyName("dockerfile_path")]
        public string? DockerfilePath { get; set; }

        /// <summary>
        /// 获取或设置构建目录。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("build_dir")]
        [System.Text.Json.Serialization.JsonPropertyName("build_dir")]
        public string? BuildDirectory { get; set; }

        /// <summary>
        /// 获取或设置环境变量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env_params")]
        [System.Text.Json.Serialization.JsonPropertyName("env_params")]
        public string? EnvironmentVariables { get; set; }

        /// <summary>
        /// 获取或设置分支。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("branch")]
        [System.Text.Json.Serialization.JsonPropertyName("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// 获取或设置包名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_name")]
        [System.Text.Json.Serialization.JsonPropertyName("package_name")]
        public string? PackageName { get; set; }

        /// <summary>
        /// 获取或设置包版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_version")]
        [System.Text.Json.Serialization.JsonPropertyName("package_version")]
        public string? PackageVersion { get; set; }

        /// <summary>
        /// 获取或设置镜像信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_info")]
        [System.Text.Json.Serialization.JsonPropertyName("image_info")]
        public Types.Image? Image { get; set; }

        /// <summary>
        /// 获取或设置代码信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("code_detail")]
        public Types.Code? Code { get; set; }

        /// <summary>
        /// 获取或设置是否回放流量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_rebuild")]
        [System.Text.Json.Serialization.JsonPropertyName("is_rebuild")]
        public bool? IsRebuild { get; set; }

        /// <summary>
        /// 获取或设置是否回滚。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rollback")]
        [System.Text.Json.Serialization.JsonPropertyName("rollback")]
        public bool? IsRollback { get; set; }

        /// <summary>
        /// 获取或设置自定义采集日志路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_logs")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_logs")]
        public string? CustomLogPath { get; set; }

        /// <summary>
        /// 获取或设置版本备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("version_remark")]
        public string? VersionRemark { get; set; }

        /// <summary>
        /// 获取或设置版本历史名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("snapshot_name")]
        [System.Text.Json.Serialization.JsonPropertyName("snapshot_name")]
        public string? SnapshotName { get; set; }

        /// <summary>
        /// 获取或设置延迟健康检查秒数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("initial_delay_seconds")]
        [System.Text.Json.Serialization.JsonPropertyName("initial_delay_seconds")]
        public int? InitialDelaySeconds { get; set; }

        /// <summary>
        /// 获取或设置 CFS 挂载列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mount_volume_info")]
        [System.Text.Json.Serialization.JsonPropertyName("mount_volume_info")]
        public IList<Types.VolumeMount>? VolumeMountList { get; set; }

        /// <summary>
        /// 获取或设置是否使用统一域名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_union")]
        [System.Text.Json.Serialization.JsonPropertyName("enable_union")]
        public bool? EnableUnion { get; set; }

        /// <summary>
        /// 获取或设置服务路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("server_path")]
        [System.Text.Json.Serialization.JsonPropertyName("server_path")]
        public string? ServerPath { get; set; }

        /// <summary>
        /// 获取或设置是否更新 CLS。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_update_cls")]
        [System.Text.Json.Serialization.JsonPropertyName("is_update_cls")]
        public bool? RequireUpdateCLS { get; set; }

        /// <summary>
        /// 获取或设置自动扩缩容策略组列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("policy_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("policy_detail")]
        public IList<Types.HPAPolicy>? HPAPolicyList { get; set; }
    }
}
