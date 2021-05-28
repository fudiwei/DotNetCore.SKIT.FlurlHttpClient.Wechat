using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/menu/trymatch 接口的请求。</para>
    /// </summary>
    public class CgibinMenuTryMatchRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置用户微信号或 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        [System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;
    }
}
