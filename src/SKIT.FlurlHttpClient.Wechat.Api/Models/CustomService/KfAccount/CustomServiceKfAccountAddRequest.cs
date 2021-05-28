using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /customservice/kfaccount/add 接口的请求。</para>
    /// </summary>
    public class CustomServiceKfAccountAddRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置客服账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kf_account")]
        [System.Text.Json.Serialization.JsonPropertyName("kf_account")]
        public string KfAccount { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置客服昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nickname")]
        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
        public string? Nickname { get; set; }

        /// <summary>
        /// 获取或设置客服账号登录密码（需 MD5 哈希）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("password")]
        [System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }
    }
}
