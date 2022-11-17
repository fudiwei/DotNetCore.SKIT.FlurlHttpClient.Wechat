using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/deletecloudbaserunserverversion 接口的请求。</para>
    /// </summary>
    public class ComponentTCBDeleteCloudBaseRunServerVersionRequest : WechatApiRequest, IInferable<ComponentTCBDeleteCloudBaseRunServerVersionRequest, ComponentTCBDeleteCloudBaseRunServerVersionResponse>
    {
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
        /// 获取或设置服务名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("server_name")]
        [System.Text.Json.Serialization.JsonPropertyName("server_name")]
        public string ServerName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否删除服务。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_delete_server")]
        [System.Text.Json.Serialization.JsonPropertyName("is_delete_server")]
        public bool? RequireDeleteServer { get; set; }

        /// <summary>
        /// 获取或设置是否删除镜像。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_delete_image")]
        [System.Text.Json.Serialization.JsonPropertyName("is_delete_image")]
        public bool? RequireDeleteImage { get; set; }
    }
}
