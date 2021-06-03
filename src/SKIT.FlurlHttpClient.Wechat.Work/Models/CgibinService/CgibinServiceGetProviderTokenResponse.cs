using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/get_provider_token 接口的响应。</para>
    /// </summary>
    public class CgibinServiceGetProviderTokenResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置服务商凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("provider_access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("provider_access_token")]
        public string ProviderAccessToken { get; set; } = default!;

        /// <summary>
        /// 获取或设置服务商凭证有效时间（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
    }
}
