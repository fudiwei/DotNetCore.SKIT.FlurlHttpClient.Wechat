using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/setbetaweappnickname 接口的请求。</para>
    /// </summary>
    public class WxaSetBetaWeappNicknameRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置小程序名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Nickname { get; set; } = string.Empty;
    }
}
