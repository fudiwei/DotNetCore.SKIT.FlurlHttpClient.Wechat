using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/unbind_tester 接口的请求。</para>
    /// </summary>
    public class WxaUnbindTesterRequest : WechatApiRequest, IMapResponse<WxaUnbindTesterRequest, WxaUnbindTesterResponse>
    {
        /// <summary>
        /// 获取或设置体验者微信号。与字段 <see cref="UserString"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wechatid")]
        [System.Text.Json.Serialization.JsonPropertyName("wechatid")]
        public string? Wxname { get; set; }

        /// <summary>
        /// 获取或设置人员对应的唯一字符串。与字段 <see cref="Wxname"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userstr")]
        [System.Text.Json.Serialization.JsonPropertyName("userstr")]
        public string? UserString { get; set; }
    }
}
