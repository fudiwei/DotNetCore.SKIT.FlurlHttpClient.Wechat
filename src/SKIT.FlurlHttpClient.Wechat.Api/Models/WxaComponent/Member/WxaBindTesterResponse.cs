using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/bind_tester 接口的响应。</para>
    /// </summary>
    public class WxaBindTesterResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置人员对应的唯一字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userstr")]
        [System.Text.Json.Serialization.JsonPropertyName("userstr")]
        public string UserString { get; set; } = default!;
    }
}
