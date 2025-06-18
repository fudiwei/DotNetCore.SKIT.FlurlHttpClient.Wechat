using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/createcloudbaserunresauth 接口的请求。</para>
    /// </summary>
    public class ComponentTCBCreateCloudBaseRunResauthRequest : WechatApiRequest, IInferable<ComponentTCBCreateCloudBaseRunResauthRequest, ComponentTCBCreateCloudBaseRunResauthResponse>
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
    }
}
