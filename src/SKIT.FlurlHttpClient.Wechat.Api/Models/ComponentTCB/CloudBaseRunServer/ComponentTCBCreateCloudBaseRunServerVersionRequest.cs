using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/createcloudbaserunserverversion 接口的请求。</para>
    /// </summary>
    public class ComponentTCBCreateCloudBaseRunServerVersionRequest : WechatApiRequest, IInferable<ComponentTCBCreateCloudBaseRunServerVersionRequest, ComponentTCBCreateCloudBaseRunServerVersionResponse>
    {
        public static class Types
        {
            public class Image
            {
                /// <summary>
                /// 获取或设置镜像仓库名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("repository_name")]
                [System.Text.Json.Serialization.JsonPropertyName("repository_name")]
                public string? RepositoryName { get; set; }

                /// <summary>
                /// 获取或设置是否公有。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_public")]
                [System.Text.Json.Serialization.JsonPropertyName("is_public")]
                public bool? IsPublic { get; set; }

                /// <summary>
                /// 获取或设置镜像 Tag 名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tag_name")]
                [System.Text.Json.Serialization.JsonPropertyName("tag_name")]
                public string? TagName { get; set; }

                /// <summary>
                /// 获取或设置镜像服务地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("server_addr")]
                [System.Text.Json.Serialization.JsonPropertyName("server_addr")]
                public string? ServerAddress { get; set; }

                /// <summary>
                /// 获取或设置镜像拉取地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_url")]
                [System.Text.Json.Serialization.JsonPropertyName("image_url")]
                public string? ImageUrl { get; set; }
            }

            public class Code
            {
                public static class Types
                {
                    public class Repository
                    {
                        /// <summary>
                        /// 获取或设置仓库名字。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string? Name { get; set; }

                        /// <summary>
                        /// 获取或设置仓库完整名字。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("full_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("full_name")]
                        public string? FullName { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置仓库信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public Types.Repository? Repository { get; set; }

                /// <summary>
                /// 获取或设置仓库地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string? Url { get; set; }
            }

            public class ImageSecret
            {
                /// <summary>
                /// 获取或设置镜像地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("registry_server")]
                [System.Text.Json.Serialization.JsonPropertyName("registry_server")]
                public string? RegistryServer { get; set; }

                /// <summary>
                /// 获取或设置用户名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_name")]
                [System.Text.Json.Serialization.JsonPropertyName("user_name")]
                public string? Username { get; set; }

                /// <summary>
                /// 获取或设置密码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("password")]
                [System.Text.Json.Serialization.JsonPropertyName("password")]
                public string? Password { get; set; }

                /// <summary>
                /// 获取或设置邮箱。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("email")]
                [System.Text.Json.Serialization.JsonPropertyName("email")]
                public string? Email { get; set; }
            }

            public class VolumeMount
            {
                public static class Types
                {
                    public class NFSVolumeSource
                    {
                        /// <summary>
                        /// 获取或设置服务名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("server")]
                        [System.Text.Json.Serialization.JsonPropertyName("server")]
                        public string? Server { get; set; }

                        /// <summary>
                        /// 获取或设置路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("path")]
                        [System.Text.Json.Serialization.JsonPropertyName("path")]
                        public string? Path { get; set; }

                        /// <summary>
                        /// 获取或设置是否只读。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("read_only")]
                        [System.Text.Json.Serialization.JsonPropertyName("read_only")]
                        public bool? IsReadOnly { get; set; }

                        /// <summary>
                        /// 获取或设置 Secret 名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("secret_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("secret_name")]
                        public string? SecretName { get; set; }

                        /// <summary>
                        /// 获取或设置是否允许临时目录。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("enable_empty_dir_volume")]
                        [System.Text.Json.Serialization.JsonPropertyName("enable_empty_dir_volume")]
                        public bool? EnableEmptyDirectoryVolume { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置资源名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置挂载路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mount_path")]
                [System.Text.Json.Serialization.JsonPropertyName("mount_path")]
                public string? MountPath { get; set; }

                /// <summary>
                /// 获取或设置是否只读。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("read_only")]
                [System.Text.Json.Serialization.JsonPropertyName("read_only")]
                public bool? IsReadOnly { get; set; }

                /// <summary>
                /// 获取或设置 NFS 挂载信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nfs_volumes")]
                [System.Text.Json.Serialization.JsonPropertyName("nfs_volumes")]
                public IList<Types.NFSVolumeSource>? NFSVolumes { get; set; }
            }

            public class ServiceVolume
            {
                public static class Types
                {
                    public class NFSVolumeSource : VolumeMount.Types.NFSVolumeSource
                    {
                    }

                    public class EmptyDirectoryVolumeSource
                    {
                        /// <summary>
                        /// 获取或设置是否允许临时目录。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("enable_empty_dir_volume")]
                        [System.Text.Json.Serialization.JsonPropertyName("enable_empty_dir_volume")]
                        public bool? EnableEmptyDirectoryVolume { get; set; }

                        /// <summary>
                        /// 获取或设置媒介。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("medium")]
                        [System.Text.Json.Serialization.JsonPropertyName("medium")]
                        public string? Medium { get; set; }

                        /// <summary>
                        /// 获取或设置数据卷大小。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("size_limit")]
                        [System.Text.Json.Serialization.JsonPropertyName("size_limit")]
                        public string? SizeLimit { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置资源名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置 Secret 名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("secret_name")]
                [System.Text.Json.Serialization.JsonPropertyName("secret_name")]
                public string? SecretName { get; set; }

                /// <summary>
                /// 获取或设置是否允许临时目录。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_empty_dir_volume")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_empty_dir_volume")]
                public bool? EnableEmptyDirectoryVolume { get; set; }

                /// <summary>
                /// 获取或设置临时目录数据卷详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("empty_dir")]
                [System.Text.Json.Serialization.JsonPropertyName("empty_dir")]
                public Types.EmptyDirectoryVolumeSource? EmptyDirectoryVolume { get; set; }
            }

            public class ServiceVolumeMount
            {
                /// <summary>
                /// 获取或设置资源名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置挂载路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mount_path")]
                [System.Text.Json.Serialization.JsonPropertyName("mount_path")]
                public string? MountPath { get; set; }

                /// <summary>
                /// 获取或设置是否只读。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("read_only")]
                [System.Text.Json.Serialization.JsonPropertyName("read_only")]
                public bool? IsReadOnly { get; set; }

                /// <summary>
                /// 获取或设置子路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_path")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_path")]
                public string? SubPath { get; set; }

                /// <summary>
                /// 获取或设置传播挂载方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mount_propagation")]
                [System.Text.Json.Serialization.JsonPropertyName("mount_propagation")]
                public string? MountPropagation { get; set; }
            }

            public class ES : ComponentTCBEstablishCloudBaseRunServerRequest.Types.ES
            {
            }

            public class SidecarSpecification
            {
                /// <summary>
                /// 获取或设置容器镜像。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("container_image")]
                [System.Text.Json.Serialization.JsonPropertyName("container_image")]
                public string? ContainerImage { get; set; }

                /// <summary>
                /// 获取或设置容器端口。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("container_port")]
                [System.Text.Json.Serialization.JsonPropertyName("container_port")]
                public int? ContainerPort { get; set; }

                /// <summary>
                /// 获取或设置容器的名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("container_name")]
                [System.Text.Json.Serialization.JsonPropertyName("container_name")]
                public string? ContainerName { get; set; }

                /// <summary>
                /// 获取或设置环境变量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("env_var")]
                [System.Text.Json.Serialization.JsonPropertyName("env_var")]
                public string? EnvironmentVariables { get; set; }

                /// <summary>
                /// 获取或设置延迟健康检查秒数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("initial_delay_seconds")]
                [System.Text.Json.Serialization.JsonPropertyName("initial_delay_seconds")]
                public int? InitialDelaySeconds { get; set; }

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
                /// 获取或设置安全特性信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("security")]
                [System.Text.Json.Serialization.JsonPropertyName("security")]
                public SecurityContext? SecurityContext { get; set; }

                /// <summary>
                /// 获取或设置挂载列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("volume_mount_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("volume_mount_infos")]
                public IList<Types.VolumeMount>? VolumeMountList { get; set; }
            }

            public class SecurityContext
            {
                public static class Types
                {
                    public class Capability
                    {
                        /// <summary>
                        /// 获取或设置启用安全能力项列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("add")]
                        [System.Text.Json.Serialization.JsonPropertyName("add")]
                        public IList<string>? AddList { get; set; }

                        /// <summary>
                        /// 获取或设置禁用安全能力向列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("drop")]
                        [System.Text.Json.Serialization.JsonPropertyName("drop")]
                        public IList<string>? DropList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置安全特性信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("capabilities")]
                [System.Text.Json.Serialization.JsonPropertyName("capabilities")]
                public Types.Capability? Capability { get; set; }
            }

            public class HPAPolicy
            {
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
        /// 获取或设置上传类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_type")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_type")]
        public string UploadType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置流量占比（范围：0～100）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("flow_ratio")]
        [System.Text.Json.Serialization.JsonPropertyName("flow_ratio")]
        public int FlowRatio { get; set; }

        /// <summary>
        /// 获取或设置 CPU 大小（单位：核）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cpu")]
        [System.Text.Json.Serialization.JsonPropertyName("cpu")]
        public decimal CPUSize { get; set; }

        /// <summary>
        /// 获取或设置内存大小（单位：GB）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mem")]
        [System.Text.Json.Serialization.JsonPropertyName("mem")]
        public decimal MemorySize { get; set; }

        /// <summary>
        /// 获取或设置最小副本数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("min_num")]
        [System.Text.Json.Serialization.JsonPropertyName("min_num")]
        public int MinNumber { get; set; }

        /// <summary>
        /// 获取或设置最大副本数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_num")]
        [System.Text.Json.Serialization.JsonPropertyName("max_num")]
        public int MaxNumber { get; set; }

        /// <summary>
        /// 获取或设置策略类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("policy_type")]
        [System.Text.Json.Serialization.JsonPropertyName("policy_type")]
        public string PolicyType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置策略阈值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("policy_threshold")]
        [System.Text.Json.Serialization.JsonPropertyName("policy_threshold")]
        public decimal PolicyThreshold { get; set; }

        /// <summary>
        /// 获取或设置服务端口。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("container_port")]
        [System.Text.Json.Serialization.JsonPropertyName("container_port")]
        public int ContainerPort { get; set; }

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
        /// 获取或设置私有镜像密钥信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_secret_info")]
        [System.Text.Json.Serialization.JsonPropertyName("image_secret_info")]
        public Types.ImageSecret? ImageSecret { get; set; }

        /// <summary>
        /// 获取或设置私有镜像认证密钥。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_pull_secret")]
        [System.Text.Json.Serialization.JsonPropertyName("image_pull_secret")]
        public string? ImagePullSecret { get; set; }

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
        /// 获取或设置访问类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_type")]
        [System.Text.Json.Serialization.JsonPropertyName("access_type")]
        public int? AccessType { get; set; }

        /// <summary>
        /// 获取或设置 ES 信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("es_info")]
        [System.Text.Json.Serialization.JsonPropertyName("es_info")]
        public Types.ES? ES { get; set; }

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
        /// 获取或设置容器的描述文件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sidecar_specs")]
        [System.Text.Json.Serialization.JsonPropertyName("sidecar_specs")]
        public IList<Types.SidecarSpecification>? SidecarSpecificationList { get; set; }

        /// <summary>
        /// 获取或设置安全特性信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("security")]
        [System.Text.Json.Serialization.JsonPropertyName("security")]
        public Types.SecurityContext? SecurityContext { get; set; }

        /// <summary>
        /// 获取或设置服务磁盘挂载列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_volumes")]
        [System.Text.Json.Serialization.JsonPropertyName("service_volumes")]
        public IList<Types.ServiceVolume>? ServiceVolumeList { get; set; }

        /// <summary>
        /// 获取或设置数据卷挂载列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_volume_mounts")]
        [System.Text.Json.Serialization.JsonPropertyName("service_volume_mounts")]
        public IList<Types.ServiceVolumeMount>? ServiceVolumeMountList { get; set; }

        /// <summary>
        /// 获取或设置 JnsGw 创建状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_create_jns_gw")]
        [System.Text.Json.Serialization.JsonPropertyName("is_create_jns_gw")]
        public int? CreateJnsGwStatus { get; set; }

        /// <summary>
        /// 获取或设置 Dockerfile 包含状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_dockerfile")]
        [System.Text.Json.Serialization.JsonPropertyName("has_dockerfile")]
        public int? HasDockerfileStatus { get; set; }

        /// <summary>
        /// 获取或设置基础镜像。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("base_image")]
        [System.Text.Json.Serialization.JsonPropertyName("base_image")]
        public string? BaseImage { get; set; }

        /// <summary>
        /// 获取或设置容器启动入口命令。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entry_point")]
        [System.Text.Json.Serialization.JsonPropertyName("entry_point")]
        public string? EntryPoint { get; set; }

        /// <summary>
        /// 获取或设置仓库语言。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("repo_language")]
        [System.Text.Json.Serialization.JsonPropertyName("repo_language")]
        public string? RepositoryLanguage { get; set; }

        /// <summary>
        /// 获取或设置上传文件名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_filename")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_filename")]
        public string? UploadFileName { get; set; }

        /// <summary>
        /// 获取或设置自动扩缩容策略组列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("policy_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("policy_detail")]
        public IList<Types.HPAPolicy>? HPAPolicyList { get; set; }
    }
}
