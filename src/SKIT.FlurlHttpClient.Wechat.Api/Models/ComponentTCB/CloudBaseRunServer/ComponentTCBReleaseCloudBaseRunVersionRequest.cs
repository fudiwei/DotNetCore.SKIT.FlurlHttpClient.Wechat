using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/releasecloudbaserunversion 接口的请求。</para>
    /// </summary>
    public class ComponentTCBReleaseCloudBaseRunVersionRequest : WechatApiRequest, IInferable<ComponentTCBReleaseCloudBaseRunVersionRequest, ComponentTCBReleaseCloudBaseRunVersionResponse>
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
        /// 获取或设置发布版本名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("release_version")]
        [System.Text.Json.Serialization.JsonPropertyName("release_version")]
        public string ReleaseVersionName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置服务名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("server_name")]
        [System.Text.Json.Serialization.JsonPropertyName("server_name")]
        public string ServerName { get; set; } = string.Empty;
    }
}
