using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /nontax/getbillauthurl 接口的响应。</para>
    /// </summary>
    public class NontaxGetBillAuthUrlResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置授权链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_url")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_url")]
        public string AuthUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权链接有效时间（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_time")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
        public int ExpiresIn { get; set; }
    }
}
