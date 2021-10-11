using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v1/token 接口的请求。</para>
    /// </summary>
    public class TokenRequest : WechatOpenAIThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置申请的资源权限列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resources")]
        [System.Text.Json.Serialization.JsonPropertyName("resources")]
        public IList<string> ResourceList { get; set; } = new List<string>();

        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorization_type")]
        [System.Text.Json.Serialization.JsonPropertyName("authorization_type")]
        public string AuthorizationType { get; set; } = "client_credentials";
    }
}
