using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/getwxacodeunlimit 接口的请求。</para>
    /// </summary>
    public class WxaGetWxaCodeUnlimitRequest : WxaGetWxaCodeRequest
    {
        /// <summary>
        /// 获取或设置扫码场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        [System.Text.Json.Serialization.JsonPropertyName("scene")]
        public string Scene { get; set; } = string.Empty;
    }
}
