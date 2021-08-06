using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/dbmodifyacl 接口的请求。</para>
    /// </summary>
    public class ComponentTcbDbModifyACLRequest : WechatApiRequest
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
        /// 获取或设置集合名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collection_name")]
        [System.Text.Json.Serialization.JsonPropertyName("collection_name")]
        public string CollectionName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置权限说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acl_tag")]
        [System.Text.Json.Serialization.JsonPropertyName("acl_tag")]
        public string ACLTag { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置自定义规则。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule")]
        [System.Text.Json.Serialization.JsonPropertyName("rule")]
        public string Rule { get; set; } = string.Empty;
    }
}
