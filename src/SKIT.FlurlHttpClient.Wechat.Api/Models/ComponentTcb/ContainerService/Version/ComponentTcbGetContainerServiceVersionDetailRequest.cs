using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/getcsversiondetail 接口的请求。</para>
    /// </summary>
    public class ComponentTcbGetContainerServiceVersionDetailRequest : WechatApiRequest
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
        /// 获取或设置版本名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version_name")]
        [System.Text.Json.Serialization.JsonPropertyName("version_name")]
        public string VersionName { get; set; } = string.Empty;
    }
}
