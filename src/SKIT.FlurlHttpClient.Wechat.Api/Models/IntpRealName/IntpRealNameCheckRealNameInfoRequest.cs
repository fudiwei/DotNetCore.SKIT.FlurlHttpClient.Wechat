using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /intp/realname/checkrealnameinfo 接口的请求。</para>
    /// </summary>
    public class IntpRealNameCheckRealNameInfoRequest : WechatApiRequest, IMapResponse<IntpRealNameCheckRealNameInfoRequest, IntpRealNameCheckRealNameInfoResponse>
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置需要校验的姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("real_name")]
        [System.Text.Json.Serialization.JsonPropertyName("real_name")]
        public string RealName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置需要校验的证件类型。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cred_type")]
        [System.Text.Json.Serialization.JsonPropertyName("cred_type")]
        public int CredentialType { get; set; } = 1;

        /// <summary>
        /// 获取或设置需要校验的证件号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cred_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cred_id")]
        public string CredentialId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置通过小程序回跳获取的 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;
    }
}
