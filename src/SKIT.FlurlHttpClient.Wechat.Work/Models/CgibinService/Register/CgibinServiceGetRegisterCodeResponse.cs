using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/get_register_code 接口的响应。</para>
    /// </summary>
    public class CgibinServiceGetRegisterCodeResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置注册码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("register_code")]
        [System.Text.Json.Serialization.JsonPropertyName("register_code")]
        public string RegisterCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置注册码有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
    }
}
