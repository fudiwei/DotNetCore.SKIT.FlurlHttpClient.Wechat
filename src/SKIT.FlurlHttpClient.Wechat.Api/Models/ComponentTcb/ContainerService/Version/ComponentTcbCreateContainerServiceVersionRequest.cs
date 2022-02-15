using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/createcsversion 接口的请求。</para>
    /// </summary>
    public class ComponentTcbCreateContainerServiceVersionRequest : WechatApiRequest, IMapResponse<ComponentTcbCreateContainerServiceVersionRequest, ComponentTcbCreateContainerServiceVersionResponse>
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
                public string RepositoryName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置是否公有。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ispublic")]
                [System.Text.Json.Serialization.JsonPropertyName("ispublic")]
                public bool IsPublic { get; set; }

                /// <summary>
                /// 获取或设置镜像 Tag 名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tagname")]
                [System.Text.Json.Serialization.JsonPropertyName("tagname")]
                public string TagName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置镜像服务地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("server_addr")]
                [System.Text.Json.Serialization.JsonPropertyName("server_addr")]
                public string ServerAddress { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置镜像拉取地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_url")]
                [System.Text.Json.Serialization.JsonPropertyName("image_url")]
                public string ImageUrl { get; set; } = string.Empty;
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
                        [Newtonsoft.Json.JsonProperty("fullname")]
                        [System.Text.Json.Serialization.JsonPropertyName("fullname")]
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
                [Newtonsoft.Json.JsonProperty("registryserver")]
                [System.Text.Json.Serialization.JsonPropertyName("registryserver")]
                public string? RegistryServer { get; set; }

                /// <summary>
                /// 获取或设置用户名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("username")]
                [System.Text.Json.Serialization.JsonPropertyName("username")]
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
        /// 获取或设置上传方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_type")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_type")]
        public string UploadType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置流量占比（范围：0～100）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("flow_ratio")]
        [System.Text.Json.Serialization.JsonPropertyName("flow_ratio")]
        public int? FlowRatio { get; set; }

        /// <summary>
        /// 获取或设置 CPU 核心数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cpu")]
        [System.Text.Json.Serialization.JsonPropertyName("cpu")]
        public double? CPUCount { get; set; }

        /// <summary>
        /// 获取或设置内存大小（单位：GB）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mem")]
        [System.Text.Json.Serialization.JsonPropertyName("mem")]
        public double? MemorySize { get; set; }

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
        /// 获取或设置策略类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("policy_type")]
        [System.Text.Json.Serialization.JsonPropertyName("policy_type")]
        public string? PolicyType { get; set; }

        /// <summary>
        /// 获取或设置策略阈值（范围：0～100）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("policy_threshold")]
        [System.Text.Json.Serialization.JsonPropertyName("policy_threshold")]
        public int? PolicyThreshold { get; set; }

        /// <summary>
        /// 获取或设置端口号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("container_port")]
        [System.Text.Json.Serialization.JsonPropertyName("container_port")]
        public int? ContainerPort { get; set; }

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
        [Newtonsoft.Json.JsonProperty("image_pulls_secret")]
        [System.Text.Json.Serialization.JsonPropertyName("image_pulls_secret")]
        public string? ImagePullsSecret { get; set; }

        /// <summary>
        /// 获取或设置自定义采集日志路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_logs")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_logs")]
        public string? CustomLogPath { get; set; }

        /// <summary>
        /// 获取或设置是否开启微信令牌自动推送。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mount_wx_token")]
        [System.Text.Json.Serialization.JsonPropertyName("mount_wx_token")]
        public bool? IsMountWechatToken { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("version_remark")]
        public string? Remark { get; set; }
    }
}
