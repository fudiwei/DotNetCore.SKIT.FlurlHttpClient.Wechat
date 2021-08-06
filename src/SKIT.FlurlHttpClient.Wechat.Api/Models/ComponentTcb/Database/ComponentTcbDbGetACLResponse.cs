using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/dbgetacl 接口的响应。</para>
    /// </summary>
    public class ComponentTcbDbGetACLResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置权限说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acl_tag")]
        [System.Text.Json.Serialization.JsonPropertyName("acl_tag")]
        public string ACLTag { get; set; } = default!;

        /// <summary>
        /// 获取或设置自定义规则。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule")]
        [System.Text.Json.Serialization.JsonPropertyName("rule")]
        public string Rule { get; set; } = default!;
    }
}
