using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/createcloudbaserunenv 接口的请求。</para>
    /// </summary>
    public class ComponentTcbCreateCloudBaseRunEnvironmentRequest : WechatApiRequest, IInferable<ComponentTcbCreateCloudBaseRunEnvironmentRequest, ComponentTcbCreateCloudBaseRunEnvironmentResponse>
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置环境别名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alias")]
        [System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// 获取或设置私有网络 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vpc_id")]
        [System.Text.Json.Serialization.JsonPropertyName("vpc_id")]
        public string? VPCId { get; set; }

        /// <summary>
        /// 获取或设置子网列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_net_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_net_ids")]
        public IList<string>? SubNetIdList { get; set; }
    }
}
